# C-.Net-ASP-MVC-Project
A project undertaken as the final part of my internship with Prosper IT Consulting, where I worked as part of a scrum team of developers using Azure DevOps.

### Introduction

*Please note: you may view the application in action, as well as hear my narration of its features, by clicking the following YouTube image link to my video:*

<a href="http://www.youtube.com/watch?feature=player_embedded&v=nfdkdTCky7o
" target="_blank"><img src="http://img.youtube.com/vi/nfdkdTCky7o/0.jpg" 
alt="IMAGE ALT TEXT HERE" width="240" height="180" border="10" /></a>

As part of my internship with Prosper IT Consulting, I worked alongside my peers in developing a full stack web application using the .Net Framework and C#. 

We were each tasked with completing a series of stories to achieve a certain set of functionalities for an aspect of the overall web application, which is a content management system (CMS) for a theater group. 

In addition to the .Net Framework, I made use of Bootstrap4 and FontAwesome for the front-end of my application. 

I was tasked with developing the Rental section, where theater staff could create rental options for customers to select, and made the following features:

- Allowing for the creation of any of 3 rental types on a single create page (dynamic field changes based on desired rental type)
- Incorporating CRUD functionality by enabling visualization of all database rental items on the Index page, as well as the ability to edit or delete any rental
- Creating context-specific styling for Index page, such that depending on the rental type, only relevant data would appear on the 'rental card' itself (e.g. only rental equipment would display choking hazards and only rental rooms would display square footage prominently)
- Adding filtration functionality to the Index page (which houses all rentals in existence as boostrap 'cards') so that only rentals that match search keywords appear
- Adding filtration by price greater than target price in addition to filtration by a search term, all using the same field/search bar
- Adding a functionality to allow for filtering by price less than target price, and including a button to allow for toggling between search term or price greater than and search term or price less than target price
- Adding a functionality and a button to reset the filters so that all rental entries are visible on index page

### Stories
- [Generating Models](#generating-database-models)
- [Creating a Rental](#creating-database-rental-entry)
- [Editing a Rental](#editing-database-rental-entry)
- [Viewing a Rental](#viewing-details-of-rental-entry)
- [Deleting a Rental](#deleting-database-rental-entry)
- [Index with Filter by Name or Price Greater Than](#index-page-with-filter-by-name-or-greater-than-price)
- [Index with Filter by Name or Price Less Than](#index-page-with-filter-by-name-or-less-than-price)
- [Front End Design with Bootstrap4 and FontAwesome](#front-end-design)


### Other Sections Navigation
- [Skip to Other Skills Learned](#other-skills-learned)


#### Generating Database Models 

Created models for the rental being created

[RENTAL MODEL](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_model.cs)


#### Creating Database Rental Entry

Created the view and action required to add a new entry (record) to the tables in the database

[CREATE RENTAL VIEW](https://github.com/developeralain/DjangoProject/blob/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/views.py)
[RENTAL CONTROLLER](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_controller.cs)


#### Editing Database Rental Entry

Created the view and action required to edit an entry (record) of the table in the database

[EDIT RENTAL VIEW](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_edit.cshtml)
[RENTAL CONTROLLER](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_controller.cs)

#### Viewing Details of Rental Entry

Created the view and action required to display an entry (record) of the table in the database

[DETAILS RENTAL VIEW](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_details.cshtml)
[RENTAL CONTROLLER](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_controller.cs)

#### Deleting Database Rental Entry

Created the view and action required to delete an entry (record) of the table in the database

[DELETE RENTAL VIEW](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_delete.cshtml)
[RENTAL CONTROLLER](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_controller.cs)

#### Index Page with Filter by Name or Greater Than Price 

Enabling filtration functionality so that a user can choose to display only rentals that contain certain words or that are priced above a certain price point

[INDEX VIEW](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_index.cshtml)
[RENTAL CONTROLLER](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_controller.cs)

#### Index Page with Filter by Name or Less Than Price 

Enabling filtration functionality so that a user can choose to display only rentals that contain certain words or that are priced below a certain price point, with a button to toggle between both filtration types

[INDEX VIEW](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_index.cshtml)
[RENTAL CONTROLLER](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_controller.cs)

#### Front End Design

Leveraged Bootstrap4 and FontAwesome to create the application theme and aesthetics. I kept things simple and clean, while leaving special effects and eye-catchers to a minimum. The style and overall theme of the web application was predetermined and decided upon by the theater group client. The Index page was the focal design point from my end.

[CSS Styling](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_css.css)
[Index Page](https://github.com/developeralain/C-.Net-ASP-MVC-Project/blob/main/rental_index.cshtml)


### Other Skills Learned

Throughout this internship experience I was able to acquire and develop many important non-coding skills. These included such things as:

- Agile and Scrum methodologies of project management
	- Attended daily standups to discuss what was done, what was to be done, and any roadblocks
	- Attended weekly retrospectives to look back on the week's accomplishments, setbacks, and discuss any ideas for improvements
	to improve the experience and ultimately the end-product
	- Developed a work pattern of frequent commits that are small and allow for easier management of code as the project progresses
	
- DevOps with Azure, including Git concepts
	- Identified assigned stories on the storyboard and created new working branches accordingly
	- Committed and pushed completed working branches and generated pull requests
	- Updated local master branch, checking out branches, merging branches as required 
	- Addressed pull request rejections and re-submitted working branches along with clear documentation
	- Addressing merge conflicts and resolving them properly so as not to interfere with anyone else's work

- Research and Problem-Solving Abilities
	- Broke apart larger problems into smaller components and researched how to implement each component specifically
	- Debugged an issue by understanding what the errors are pointing to and tracing my steps back to those areas--iterating
	accordingly until the problem is solved 
	- Learned new technologies, quickly, as the project demands required, and implemented those skills specifically to the task at
	hand

- Communication and pair programming
	- Clearly articulated problems with enough contextual info so that a fellow programmer could assist in resolving it
	- Applied a focused and stepwise approach to dissecting a problem with a colleague to get at the root of the problem 
	- Explained my own code clearly to another so that their understanding, as well as my own, was enhanced, and they were able to resolve their
	code impasse and proceed successfully
