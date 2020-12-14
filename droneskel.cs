[HttpPost]
[Route("/api/[controller]/operation")]
[ProducesResponseType(typeof(void), 200)]
[ProducesResponseType(typeof(void), 400)]
[ProducesResponseType(typeof(void), 500)]

public async Task<IActionResult> Post([FromBody] EventGridEvent[] events)
{

    if (events == null)
    {
        return BadRequest("No Event for Choreography");
    }

    foreach (var e in events)
    {

        List<EventGridEvent> listEvents = new List<EventGridEvent>();
        e.Topic = eventRepository.GetTopic();
        e.EventTime = DateTime.Now;
        switch (e.EventType)
        {
            case Operations.ChoreographyOperation.ScheduleDelivery:
                {
                    var packageGen = await packageServiceCaller.UpsertPackageAsync(delivery.PackageInfo).ConfigureAwait(false);
                    if (packageGen is null)
                    {
                        //BadRequest allows the event to be reprocessed by Event Grid
                        return BadRequest("Package creation failed.");
                    }

                    //we set the event type to the next choreography step
                    e.EventType = Operations.ChoreographyOperation.CreatePackage;
                    listEvents.Add(e);
                    await eventRepository.SendEventAsync(listEvents);
                    return Ok("Created Package Completed");
                }
            case Operations.ChoreographyOperation.CreatePackage:
                {
                    var droneId = await droneSchedulerServiceCaller.GetDroneIdAsync(delivery).ConfigureAwait(false);
                    if (droneId is null)
                    {
                        //BadRequest allows the event to be reprocessed by Event Grid
                        return BadRequest("could not get a drone id");
                    }
                    e.Subject = droneId;
                    e.EventType = Operations.ChoreographyOperation.GetDrone;
                    listEvents.Add(e);
                    await eventRepository.SendEventAsync(listEvents);
                    return Ok("Drone Completed");
                }
            case Operations.ChoreographyOperation.GetDrone:
                {
                    var deliverySchedule = await deliveryServiceCaller.ScheduleDeliveryAsync(delivery, e.Subject);
                    return Ok("Delivery Completed");
                }
                return BadRequest();
        }
    }