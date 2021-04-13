# DNRTApp
Contents include the entirety of the necessary Unity assets and files for the Dartmouth Natural Resources Trust (DNRT) Mobile Application

Team4_FinalDelivery (Michael Medeiros, Daniel Sysopha, Jonathan Utroska, Nicholas Vassiliadas)

Installation Guide:
To see the code/work for the app, it will require Unity, specifically version 2019.4.11f1 (64 bit)

The specific version is saved in the Google Drive of "Deliverable" found here: https://drive.google.com/drive/folders/1osWyQTtzShrr3utPiY8Ni1lElHn7YYBn?usp=sharing
	The Unity Version is in the Zip titled "Editor"

once installed, open the project in the application 
	the project is contained in the DNRT App.rar, extract onto the desktop


-------------------------------------------------------------------------------------------------------------------------------------------------------------------

Navigate through the implemented features 

click on the "Scenes" folder
from there you should be able to see all the items demoed and some added post demo

	The names are self explanatory
		Main_3 is the main scene and contains many sub canvases
			Contact being the contact info/social media information for DNRT
			Stats being the user stat tracking phase with a timer and step/dist. counting feature
			All other canvases that are named after specific reserves are present as well, specifically ones with trails
				17 reserves in the "Reserves with Trails" tab include GPS Capable maps, the exceptions being Allen's Mill and McBratney Reserve
			Support holds different support options for the user such as emailing the developer email directly and review links to the respective stores
		
			There are 5 buttons on the main screen as well that link to other scenes 
				"Reserves without trails" 
				Donate takes the users to an in app webpage for the DNRT donation page on their official website
				Become a Member takes the users to an in app webpage for the DNRT meber sign-up page on their official website
				App Guide takes the user to an in app webpage that links to a pdf created to explain the features of the app and any issues that may arise and how to solve them
				Events takes the users to an in app webpage for the DNRT events page on their official website

		As mentioned before, there are 17 different scenes dedicated to the GPS capable maps of DNRT 
	

The Scripts Folder contains the scripts used in the app for major functionality such as the script for the timer, webview, map functionality and so on

The Prefabs folder contains quick-build reserve pages so any one who adds features to the app like more reserve pages does not have to go through the process of creating the pages
	There are 4 prefabs included involving different scenarios such as if the reserve would have a map, if the reserve includes a lot of information on the general and description tabs, and 2 different prefabs if the 
	general and description tabs each have a different amount of text e.g. general is long but description is short and vice versa
