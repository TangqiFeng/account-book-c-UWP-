# account-book （c# UWP）

###### Tangqi Feng

## Introduction
Universal Windows Platform (UWP), is a platform-homogeneous application architecture created by Microsoft and first introduced in Windows 10. 

This application helps user to note daily expenses, in order to provide a good way to organize their wealth.

Users could note items, and get previous records very easily.

##### This app includes 5 pages:

- Login Page: This app is designed for individuals with passwoed function. The dedault password is "0000", users can change the password after logged in. 

- Main Page: Two button navigate to two functions' page (add items and search items).

- Add Item Page: Providing date, item detail, income/expenditure， currency, value and location to describe a record.

- Search Items Page: Providing three ways to get previous items (by year/month/location).

- Result Display Page: A grid view shows records users searched for. beside the view, it could show total amount group by currency when users tapped "calculate" text. Also, users can delete records if they want.

## Techniques

##### Storage
- "SQLite" database is used to store items and user password.

##### Sensor
- GPS -- "Geolocator/Geoposition" is used to get current latitude/longtitude, "BasicGeoposition/MapLocationFinderResult"
 for getting current location.
 
##### VisualStateGroup
- "VisualStateManager" contains different states to display GUI when the page size changed.   e.g. Horizontal, vertical screen conversion
 
##### Page Navigation 
- "Frame.Navigate()" for conversion between different pages.

##### Data Operating
- References -- "SQlite.Net-PCL", all option and bean classes are included in folder "services".

## Feature demo video 
- [link](https://youtu.be/BGLDO7QsZy0)

## Conclusion
This app is very easy for operating, with good security, you deserve to have it!
