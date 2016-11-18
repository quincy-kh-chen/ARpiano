#The Augmented Reality Piano
Rohit U Dashrathi (rud@andrew.cmu.edu)
Quincy Chen (kunsinc@andrew.cmu.edu)

##Summary:
The project aims at developing a mobile phone application which enables the user to play a physically non-existent piano using the Augmented Reality technology and the ARToolKit/ARTag framework.

##Background: 
Everyone likes to experiment his/her music skills over a keyboard! However, it is not often that one with very basic music skills is willing to spend a good amount to buy the instrument separately. Good news is that everybody has a smartphone! With the Augmented Reality concepts learned during the 16623 course, we would like to explore their actual usability to develop an interactive mobile application which can simulate an actual piano/keyboard in the AR space. Let’s look at a rough picture of how this app will work!
Rohit and Quincy, 2 bright students took the class 16623 and developed the “Augmented Reality Piano” smartphone application. They hit 1 million downloads after 1 year of publishing it on the play store/Apple store.
Eric, an enthusiastic musician, wants to learn how to play a keyboard. However, he does not have one. He has tried to learn it through some mobile apps which imitate piano effects using the touch interface of the mobile phone. However, Eric is not satisfied due to the size limit of the smartphone screen and inability to play it by both hands which occurs consequentially due to the screen size. He decides to give this app a shot and downloads the application. He opens it and notices that app starts the smartphone camera while displaying a message on the screen to “scan a piano AR Marker”. Eric prints out a piano image on a white A4 sized paper, and keep it in front of the phone camera. The mobile app, already running the phone camera, detects the picture and displays a full-sized 3D model of a piano on the smartphone screen along with a message to “press virtual buttons on the piano marker”. Eric then tries to imitate a press-button action as if there was an actual piano on the surface of the piano AR marker. Surprisingly, he gets to hear actual piano sounds from the smartphone speaker! This is sheer Magic! 

##Challenges:
1.	Detecting 41 AR tags and creating 41 buttons in such a small perspective is difficult
2.  Detecting 41 AR tags and determining which buttons has been clicked might be computational expensive, but we need immediate audio response once the user touches the button. Therefore, it is necessary to employ an efficient type of AR tag and fast detector such as BRISK (Assignment 1).
3.  Does the distance/angle between camera and AR tags effect the algorithm?

##Minimum success criterion/Baseline performance:
1.	The app should work successfully for at least 70% of the times it is played.
2.  Minimum 8 virtual buttons (forming an octave) should work successfully.
3.  The response time for each button should less than or equal to 2 secs.

##Hope to achieve:
1.  41 virtual buttons work successfully.
2.  The response time for each button should less than or equal to 0.5 sec.

##Schedule
**Nov 9:** Review the basics of ARTag and ARToolKit learnt in the class and get familiarized with Unity and Vuforia

**Nov 16:** Integrate Vuforia framework in Unity. Learn how to integrate audio codecs with the virtual buttons. Learn how to setup virtual buttons using the ARTag Markers

**Nov 23:** Setup 41 virtual buttons, one for each key in the piano model. Create/import an AR piano model with sufficient number of keys (around 41 keys).

**Nov 30:** Interface each virtual button with the corresponding audio notes. Testing, validation and troubleshooting

**Dec 7:** Uploading and publishing the iOS app
