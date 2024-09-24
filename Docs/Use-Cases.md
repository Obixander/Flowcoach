# Use Cases

#### This is some use cases for the the Flowcoach App

# 1. User Creation
### Actor: User
### Description: The user makes their account for flowcoach using their email and password.
## Preconditions:
* App Installed
* Internet Access
## Basic Flow:
1. The user opens the app and gets prompted to login or create an account.
2. The user presses on the Create Account button.
3. The user gets prompted to fill fields with email and password
4. The system checks if the email is valid
5. The system sends a activition code to the email and asks the user to input the code
6. The user gets prompted to subscribe to use Flowcoach
7. The user pays and gets sent to the main page
## Alternativ Flow:
1. The user's email isn't valid and gets informed by the system about what an email must contain.
2. The user inputs something thats not the code sent to them.
## Exceptions:
1. The Payment failed and the system informs the user.


---
<br>
<br>

# 2. User Login  
### Actor: User
### Description: The user logins into the flowcoach app using their email and password.
## Preconditions:
* App installed
* Internet Access
* Active Subscription to FlowCoach
## Basic Flow:
1. The user opens the app and gets shown the login page.
2. The user fills the email and password fields and presses on login.
3. The system checks if the email and password are valid.
4. The User is sent to the main page.
## Alternative Flow:
1. The user's password or email is not valid and gets informed about it.
2. The User does not have a subscription active and gets promted to subscribe to flowcoach to use the app

## Exceptions: 
1. could not connect to the backend and informs the user of the app service being down

---
<br>
<br>


# 3. Emotion Panel
### Actor: User
### Description: The user uses the emotion panel to pick what emotion they're feeling
## Preconditions:
* App Installed
* User logged in
* Internet Access
## Basic Flow:
1. The user scrolls through the emotion panel until they find the emotion they're feeling
2. the user clicks/presses on the card of the emotion and gets sent to the coaching/Q&A page
## Alternativ Flow:
1. 
## Exceptions:
1. 

---
<br>
<br>

# 4. Q&A
### Actor: User
### Description: the user going through the Q&A page after selecting the emotion they're feeling 
## Preconditions:
* App Installed
* User logged in
* has used flowcoach to pick an emotion
* Internet Access
## Basic Flow:
1. The user reads/can read about the emotion they're feeling
2. The user answers/can answer some question about the emotion
3. The user's answers get saved to their journal
4. The user can then input what they want to do about the emotion based on a preselected list of answers
5. The user then gets sent to a different page about their selected emotion they want to feel
## Alternativ Flow:
1. 
## Exceptions:
1. 

---
<br>
<br>
