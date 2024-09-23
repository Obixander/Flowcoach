## Requirement Specification for Flowcoach

### Actors: 
* User
* Administrator

### Subsystem 01: User/Login System
---
1. The user needs to see a screen where they choose between login and sign up
1. The user needs to be able to create an account using an email and password.
1. Check if the users email contains @ and is atleast 2 characters long
2. The user's email needs to be check if its a valid email with a one time activation code sent to them.
3. The user's password needs to be encrypted when its stored
4. The user needs to be able to sign up for an subscription to flowcoach
5. The user needs to be able to sign in to their account using email and password
6. The user's login needs to be cached for ease of use

### Subsystem 02: Emotion Panel
---
1. The user needs to see a grid of "Cards" (Images with text) after they login
2. The user needs to be able to press on a "card" where they will be sent to the Q&A page that relates to the pressed "card"
3. The user needs to be able to scroll on the emotion panel

### Subsystem 03: Q&A
---
1. The user needs to be able to read about the emotion the picked
2. The user needs to be able to answer some questions related to the emotion
3. The user needs to be asked about how they would want to feel instead using a set list of choices
4. After the user answers how they want to feel, they need to be sent to a different page based on their answer
5. The user's answers needs to be saved to their journal automatically

### Subsystem 04: Psychoeducation
---
1. The user needs to see a grid of "Cards" (Images with text) after they press on BodyFlow
2. The user needs to be able to pick an "Sensation" to read about
3. The user needs to be able to go back to bodyflow's main page

### Subsystem 05: Journal
---
1. The user needs to be able to access their journal
2. In the user's journal they need to be able reread their saved answers

### Subsystem 06: Push Notifications
---
1. The user needs to be able to enable push notifications
2. The push notifications needs to be about the growth and strength the user has had.
3. The push notifications needs to be send every four days

### Subsystem 07: Administator System
---
1. The Admin needs to be able to access a separate website for administrating the "App"
2. The Admin needs to be able to add new content to the emotion panel
3. The admin needs to be able to add new content to a Q&A page
4. The admin needs to be able to add new content to the bodyflow page
5. The admin needs to be able to add new content to a Psychoeducation page
---
6. The admin needs to be able to remove content from the emotion panel
7. The admin needs to be able to remove content from a Q&A page
8. The admin needs to be able to remove content from the bodyflow page
9. The admin needs to be able to remove content from a Psychoeducation page
---
10. The Admin needs to be able to change content from the emotion panel
11. The admin needs to be able to change content from a Q&A page
12. The Admin needs to be able to change content from the bodyflow page
13. The admin needs to be able to change content from a Psychoeducation page

### Subsystem 08: Payment System
---
1. The user needs to be able to go to the payment page and back to the main page
2. The payment page needs to be made after its design
3. There will be no payment system as this is a prototype