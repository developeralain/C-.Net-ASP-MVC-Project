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

### Back End Stories
- [Generating Models](#generating-database-models)
- [Creating a Rental](#creating-database-rental-entry)
- [Editing a Rental](#editing-database-rental-entry)
- [Deleting a Rental](#deleting-database-rental-entry)
- [Filter by Name or Price Greater Than](#creating-functionality-to-display-scraped-data)
- [Filter by Name or Price Less Than](#create-functionality-to-access-API-and-view-the-response)


### Other Sections Navigation
- [Skip to Front End Stories](#front-end-stories)
- [Skip to Other Skills Learned](#other-skills-learned)


#### Generating Database Models 

Created models for the user and nutritional path

[MODELS](https://github.com/developeralain/DjangoProject/blob/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/forms.py)
[FORMS](https://github.com/developeralain/DjangoProject/blob/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/forms.py)

#### Creating Database Rental Entry

Created the views and templates required to render the existing user and nutrition path tables in the database

[VIEWS](https://github.com/developeralain/DjangoProject/blob/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/views.py)
[TEMPLATES](https://github.com/developeralain/DjangoProject/tree/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/templates/Nutrition)
[FORMS](https://github.com/developeralain/DjangoProject/blob/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/forms.py)

#### Editing Database Rental Entry

Created the  views and templates needed to view the full details of a given table entry and edit those details 
 
[VIEWS](https://github.com/developeralain/DjangoProject/blob/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/views.py)
[TEMPLATES](https://github.com/developeralain/DjangoProject/tree/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/templates/Nutrition)
[FORMS](https://github.com/developeralain/DjangoProject/blob/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/forms.py)

#### Deleting Database Rental Entry

Created the views and templates required to confirm a record deletion, perform the delete on a record, and redirect the user back to the database table display page

[VIEWS](https://github.com/developeralain/DjangoProject/blob/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/views.py)
[TEMPLATES](https://github.com/developeralain/DjangoProject/tree/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/templates/Nutrition)

#### Filter by Name or Greater Than Price 

Implemented the BeautifulSoup library in targeting specific HTML elements on a nutritional supplement webpage. Created a view that would strip the markup language from the scraped data and render it via table format on a template. Incorporated a page refresh button to allow for latest data from webpage to be displayed.

[VIEWS](https://github.com/developeralain/DjangoProject/blob/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/views.py)
[TEMPLATES](https://github.com/developeralain/DjangoProject/tree/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/templates/Nutrition)

#### Filter by Name or Less Than Price 

Created a view that was able to send an API request, along with required API keys and credentials, to the Nutritionix API. 
Further, it was able to take the response--which was a messy JSON dictionary--and filter it for only a select few KVPs that I needed. I then made a template to allow users to make queries, and then I connected this template to the same view so that a query would be included in the API request. 
I made another template that served to unpack the data in a neat tabular format for the user to see upon making a search query. 

[VIEWS](https://github.com/developeralain/DjangoProject/blob/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/views.py)
[TEMPLATES](https://github.com/developeralain/DjangoProject/tree/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/templates/Nutrition)


### Front End Stories
#### Bootstrap4 and FontAwesome

Leveraged Bootstrap4 and FontAwesome to create the application theme and aesthetics. I kept things simple and clean, while leaving special effects and eye-catchers to a minimum. The style and overall theme of the web application was predetermined and decided upon by the theater group client. 

[TEMPLATES](https://github.com/developeralain/DjangoProject/tree/main/this_is_my_first_djangoapp/NutritionApp/Nutrition/templates/Nutrition)

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
