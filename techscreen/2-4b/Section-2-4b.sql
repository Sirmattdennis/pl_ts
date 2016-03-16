/* === QUERY TO RETURN DESIRED TABLE DATA FOR TASK 1-3 === */
/* === This one honestly has me stumped. Only all but "current" status' elapsed time are === */
/* === acquired, and I am not fond of the way this data is being retrieved as it is === */

SELECT DISTINCT
Id,
Summary,
DATEDIFF(
	MINUTE, 
	(SELECT Timestamp FROM statuschange sc2 WHERE NewStatus = 'New' and sc2.TicketId = Id),
	(SELECT Timestamp FROM statuschange sc2 WHERE OldStatus = 'New' and sc2.TicketId = Id)
	) as 'New',
DATEDIFF(
	MINUTE, 
	(SELECT Timestamp FROM statuschange sc2 WHERE NewStatus = 'In Progress' and sc2.TicketId = Id),
	(SELECT Timestamp FROM statuschange sc2 WHERE OldStatus = 'In Progress' and sc2.TicketId = Id)
	) as 'In Progress',
DATEDIFF(
	MINUTE, 
	(SELECT Timestamp FROM statuschange sc2 WHERE NewStatus = 'Closed' and sc2.TicketId = Id),
	(SELECT Timestamp FROM statuschange sc2 WHERE OldStatus = 'Closed' and sc2.TicketId = Id)
	) as 'Closed',
DATEDIFF(
	MINUTE, 
	(SELECT Timestamp FROM statuschange sc2 WHERE NewStatus = 'Reopened' and sc2.TicketId = Id),
	(SELECT Timestamp FROM statuschange sc2 WHERE OldStatus = 'Reopened' and sc2.TicketId = Id)
	) as 'Reopened'
FROM ticket
LEFT JOIN statuschange sc ON Id = sc.TicketId;