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
