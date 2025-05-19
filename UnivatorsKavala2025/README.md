#Use case
=========

This is a use case for the Univators Kavala 2025 bootcamp. 
The goal is to create a web API (REST Application Programming Interface) for a
Public Event Listings with Event Management.

## Public Read
The public can 
* browse and read details of upcoming events (concerts, conferences, festivals), 
view event details  (date, time, location, description), and potentially see public ticket information.

## Admin Write/Modify (API Key Required)
Only authorized event organizers or administrators with the correct API key can:
* Create new event listings.
* Update event details (time, location, description, ticket prices, ticket availability)
* Cancel or postpone events.
* Delete events that are no longer relevant.


# Similar Use Cases
 
## Publicly Available Job Board with Job Posting Management:

Public Read: Anyone can browse job listings, view job descriptions, company information, and application instructions.
Admin Write/Modify (API Key Required - likely for employers or job board admins): Only authenticated employers or administrators with the correct API key can:
Post new job openings.
Edit or update existing job postings.
Mark job postings as filled or expired.
Manage company profiles on the job board.


## Publicly Accessible Sensor Data with Data Management:

example https://www.opensensorweb.de/en/

* Public Read: Anyone can access and visualize real-time or historical data from publicly 
available sensors (e.g., weather stations, traffic sensors, air quality monitors).
**Admin Write/Modify (API Key Required): Only authorized personnel with the correct API key can:
**Register new sensors and their metadata.
**Update sensor configurations (e.g., reporting frequency, calibration).
**Potentially flag or remove erroneous data entries.


-------------------------------------------------------------
Tech Training
*ASP.NET Core ecosystem
*Web APIs
*Secure Web APIs

*Model classes and EntityFramework
*CRUD operations
*Design of API aligned to Business Needs

*Business case 
*Implementation and Testing
*Presentation of the Deliverables