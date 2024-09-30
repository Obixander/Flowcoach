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
### Description: The user interacts with the emotion panel to select how they are feeling.
## Preconditions:
* App is installed
* User is logged in
* Internet access is available
## Basic Flow:
1. The user scrolls through the emotion panel to browse different emotions.
2. The user selects an emotion by clicking/pressing on the corresponding card.
3. The user is redirected to the coaching/Q&A page for the selected emotion.
## Alternativ Flow:
1. 
## Exceptions:
1. No Internet Access: If the app requires an internet connection to load the emotions, an error message should be displayed (e.g., "No internet connection available. Please try again later").

2. Empty Emotion Panel: If the emotion panel fails to load, an error message should be displayed, and the user should be prompted to refresh or retry.

---
<br>
<br>

# 4. Q&A
### Actor: User
### Description: The user interacts with the Q&A page after selecting an emotion.
## Preconditions:
* App is installed
* User is logged in
* The user has selected an emotion from the emotion panel
* Internet access is available
## Basic Flow:
1. The user reads/can read about the emotion they're feeling
2. The user answers/can answer some question about the emotion
3. The system automatically saves the user’s answers in their journal.
4. The user selects from a pre-defined list how they would like to feel instead of the current emotion.
5. Based on their selection, the user is redirected to a page that corresponds to the desired emotional state.
## Alternativ Flow:
1. User skips answering some questions: If the user chooses not to answer every question, the system should still allow them to proceed and save partial responses.
## Exceptions:
1. No Internet Access: If the journal cannot be saved due to lack of internet access, the system should display an error message and provide an option to retry later.

---
<br>
<br>

æ