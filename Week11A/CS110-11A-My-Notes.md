# CS110 Action 11A — My seminar and engine experiment

Learner / folder: [add your name or approved identifier]
Engine route: unity
Work mode: team
My personal repository / one Canvas submission link: https://github.com/anguyen0344/CS-110/tree/main/Week11A
Team repository: https://github.com/Magic-Penguin/DUFF--GDP

## GitHub checks before and after work

I downloaded my CS-110 repository from GitHub and opened the
10B Unity project successfully. I copied the project into
Week11A/EngineProject and used that copy for Action 11A.
The ZIP download is not connected to Git. My final upload
and GitHub link check are still pending.

## 1. Our Attention Accord — shared plan/reference

Huddle start / end: 2pm – 2:10pm

Team / lead / production purpose:
Team Duff / Lead: An Nguyen
Understand how C# controls movement, rotation, and color in Unity.

Member → focus question → capture method → promised contribution:
An Nguyen → Why does movement in Update() need Time.deltaTime?
→ Notes, code, and test screenshots
→ Explain Time.deltaTime and compare Speed 0, 1, and 2.
Other members’ questions and contributions are recorded in our team plan.

Plan file, board photo or shared-document link:
Week11A/Evidence/Whiteboard/whiteboard.png
Team repository: https://github.com/Magic-Penguin/DUFF--GDP

Return-to-team time and how we will use the findings:
3 pm
Compare our results and use them to choose movement settings
and troubleshoot our Unity projects.

## My personal attention brief

I need to understand:
How Update() and Time.deltaTime control movement over time.

I will capture:
Notes, scripts, and screenshots of movement, rotation, color,
and the Speed 0, 1, and 2 tests.

I will return with:
An explanation of Time.deltaTime, my test results,
and my boundary-stop experiment.

My evidence will be saved at:
Week11A/Evidence/ in my personal CS-110 repository.

How this helps our team build:
My findings can help the team adjust movement speed
and stop objects at a boundary.

## 2. My seminar notes

Class and object in my own words:
A class defines data and behavior. An object is an instance
of a class. TranslateObject is a class, and each cube has
its own instance of that component.

One field/property and one method:
The speed field stores the movement rate.
The Speed property provides get/set access to that field.
Update() is a method Unity calls every frame to move the cube.

My question coming into the seminar:
Why do we multiply Speed by Time.deltaTime in Update()?

## My host translation

Engine / version / language:
Unity 6.6 / 6000.6.7f1 / C#.

Familiar C# idea → engine equivalent:
In 10B, Greeting stored a Name and BuildMessage() returned
text for the console. In Unity, TranslateObject stores speed,
and Update() uses transform.Translate() to move a visible cube.
Both examples connect stored data with methods and an output.

Who calls initialization and repeated updates?
Unity calls Start() once before the component’s first Update().
It calls Update() every frame while the component is enabled
and its GameObject is active.

One discovery I shared with the team:
Changing Speed affects movement without changing rotation
because the behaviors are in separate components.

## 3. My individual base

My source files / scene:
Scene: Assets/Scenes/EngineTransfer11A.unity
Scripts: Assets/Scripts/EngineTransfer11A/
TranslateObject.cs, RotateObject.cs, ChangeObjectColor.cs.

Starting values and prediction:
Speed = 1, Degrees Per Second = 90, Tint = cyan.
I predicted the cube would move right, rotate, and appear cyan.
At Speed 0, movement would stop. At Speed 2, it would move
twice as fast. Changing Tint to red before restarting Play
mode would make the cube red.

Actual movement / rotation / color result:
The cube moved right, rotated, and received its startup color.
At Speed 0, it stopped moving. At Speed 2, it moved faster.
After changing Tint and restarting Play mode, it turned red.

The class/property/method responsible:
TranslateObject uses the Speed property in Update() and calls
transform.Translate() with Time.deltaTime.
RotateObject uses DegreesPerSecond in Update() and calls
transform.Rotate().
ChangeObjectColor applies Tint to the material in Start().

Frustration or error, and how I investigated:
I did not encounter an error during the base tests.
I changed one value at a time and restarted Play mode
to compare the results.

Evidence:
Week11A/Evidence/BaseTests/

## 4. My experiment and return to the team

Change beyond the base:
I added StopAtBoundary.cs in a separate scene.
My prediction was that the cube would stop at X = 3
while continuing to rotate.

Observed result or exact error / next step:
At first, the cube did not stop because I attached the script
to a separate object. I moved the script onto MyMarker.
The cube then stopped at X = 3 and continued rotating.

Prefab or saved scene and two-instance comparison:
I saved MyMarker as a prefab and created two instances.
One used Speed 1 and the other used Speed 2.
The second instance moved faster. Each instance kept its own
speed value. A prefab stores a reusable setup; live instances
still require memory and processing.

What I promised → what I actually returned:
I promised an explanation of Time.deltaTime and movement tests.
I completed the scripts, Speed 0/1/2 tests, screenshots,
and a boundary-stop experiment.

My interpretation/recommendation and supporting evidence:
Separate components make behavior easier to adjust and debug.
My boundary test showed that the script must be attached to
the object containing the movement component.
Evidence: Week11A/Evidence/Extension/boundary-stop.png
and Week11A/Evidence/BaseTests/two-instances.png.

How the team will use it; what I learned from someone else:
The team can use these results to adjust movement speed
and limit an object's position.
Learning from a classmate: Not yet recorded.

## Source and evidence

[Link my project, scene, whiteboard screenshots/photos, base/extension evidence and checked source. All my authored work belongs in this personal repository.]

My individual engine base status: [working / blocked — explain].
My individual extension status: [result / error and next step].
Help received: [describe].

Commit and push all my authored work, including board captures, notes, project and evidence, to my personal repository. Open the pushed files/images and test the personal URL and applicable team URL/member links. Submit the one personal repository URL in Canvas; this README contains the team link if applicable. This export is not Canvas submission.

## AI and official documentation check

Question: Why do we multiply Speed by Time.deltaTime in Update()?

AI explanation: Multiplying a rate per second by elapsed frame
time calculates how far the object should move during a frame.

Official source:
https://docs.unity3d.com/ScriptReference/Time-deltaTime.html

Source check:  Unity’s official documentation defines Time.deltaTime
as the interval in seconds between frames. Its example multiplies
a rotation rate by Time.deltaTime, which supports the AI explanation
about converting a rate per second into a change per frame.


My test: At Speed 0, the cube stopped moving. At Speed 2,
it moved faster than at Speed 1.

Test limitation: I did not compare different frame rates.

Decision:  Keep the explanation because it agrees with Unity’s
documentation. My tests showed that Speed 0 stopped movement
and Speed 2 moved the cube faster. However, I did not test
different frame rates, so my experiment only checked speed changes.

