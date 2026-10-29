# CS110 / Action 10B / Three Hello World Investigations

Current phase: independent study with teams and tools.

## My transfer note / saved in the same README

What stayed the same: I reused the Greeting class, Name property, and BuildMessage() method across Console, WPF, and Unity.

What changed: Console displayed the message when the program started. WPF displayed it after a button click. Unity logged it from Start().

Evidence: Evidence/console-output.png, Evidence/wpf-output.png, and Evidence/unity-output.png.

Possible A1 use: I could reuse this pattern to display a welcome message with the player's name in a Minecraft-inspired game.

## Lecture investigation notes

Three concepts:
1. A class defines a type of object.
2. An object is an instance created from a class.
3. A method performs an action and may return a value.
Prediction:
If I set Name to "An", BuildMessage() will return "Hello, world, An!".
Question:
How can the same Greeting class produce output in Console, WPF, and Unity?

Peer check:
My teammate checked my code and output and confirmed it worked.
I kept my code because no changes were suggested.
Evidence: Evidence/peer-check.png

## Console investigation notes

Prediction: The console would display "Hello, world, An!".
Attempt: Created Greeting, set Name to "An", and called BuildMessage().
Result: The console displayed "Hello, world, An!".
Explanation: BuildMessage() returns the text; Console.WriteLine displays it.
Evidence: Evidence/console-output.png

## XAML / WPF investigation notes

Prediction: Clicking Say Hello would display "Hello, world, An!".
Attempt: Created a XAML window and connected the button to SayHello_Click.
Result: The greeting appeared after clicking the button.
Explanation: XAML defines the controls. The C# handler calls BuildMessage() and updates MessageText.Text.
Evidence: Evidence/wpf-output.png

## Engine investigation notes

Engine: Unity 6.6 (6000.6.7f1)
Language: C#
Project path: Action10B/EngineTrial/HelloUnity

Prediction: Starting the scene would print "Hello, world, An!".

Attempt: Created a Cube named Beacon, attached HelloWorld.cs, and reused Greeting.cs from my Console project.

Result: The Unity Console displayed "Hello, world, An!".

Explanation: Greeting stores the name. BuildMessage() returns a string. Unity calls Start(), and my script uses Debug.Log() to display the message.

Evidence: Evidence/unity-output.png

AI investigation:
AI explained that Start() triggers my greeting code and Debug.Log() displays its result.

Official sources:
https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html
https://docs.unity3d.com/ScriptReference/Debug.Log.html

Source check: Unity's documentation explains that Start runs before the first frame update when the script is enabled, and Debug.Log writes a message to the Unity Console.

Small test: Changed Name to "Duff", saved, and restarted Play mode.
Observed result: The Unity Console displayed "Hello, world, Duff!".
Decision: Keep the AI explanation because the documentation and my test support it.
Test evidence: Evidence/unity-ai-test.png

Git ignore plan: Keep Assets and its .meta files, Packages, and ProjectSettings. Exclude Library, Temp, Logs, and build folders.

Next step: Save the project, upload the required source and evidence, and submit my repository link.

## Working arrangement
Group
Lead: An Nguyen
Members / contributions: An Nguyen - independently building and testing Console, WPF, and Unity projects; participating in team discussion and feedback.
Task | Owner | Status:
Task | Owner | Status
Build and test Console project | An Nguyen | Done
Build and test WPF project | An Nguyen | Done
Build and test Unity project | An Nguyen | Done
Verify AI explanation and run a small test | An Nguyen | [Actual status]
Discuss concepts and review results with Duff | An Nguyen + peer |  finished
Upload source, evidence, README and receipt | An Nguyen | finished



## My handoff
GitHub: https://github.com/anguyen0344/CS-110/upload/main/Week10/Action10B
Required: Console/, WPF/, EngineTrial/, Evidence/ and cs110-10b-receipt.txt.
Canvas: https://sbccd.instructure.com/courses/66804/assignments/1913888
This record does not verify submission or grading.
