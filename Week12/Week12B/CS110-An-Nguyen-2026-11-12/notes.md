# An Nguyen

# prep
repo: https://github.com/anguyen0344/CS-110
gitTest: I edited and saved Week12A/git-test.html in VS Code. I opened it in Chrome and confirmed that the heading appeared. I committed the file, pushed it to my personal CS-110 repository, and verified that the file appeared on GitHub.

Commit: Add Action 12A Git workflow test
Evidence: https://github.com/anguyen0344/CS-110/blob/main/Week12/Week12A/git-test.html
access: I’m working solo for Action 12A. I verified that Week12/Week12A/git-test.html is visible in my personal GitHub repository after pushing it.
video1: Observation: The video introduces a simple game development pipeline that covers mindset, folder structure, documentation, and tools.

Useful idea: The idea that documentation grows with the project stood out to me. For my solo project, I can start with a short README and update it with how to run the Unity scene and what I tested.

Question: What should I put in my README at the start, and what can I add after I test the game?
video2: Observation: The video explains that a growth mindset means taking on challenges, learning from mistakes, and being open to feedback.

Useful idea and interpretation: I can use a failed test to decide what to try next. In my solo Unity project, if the beacon doesn’t activate when I press E nearby, I can check the interaction range first and test again after changing one thing.

Question: How can I tell whether the issue is with the interaction range or with Unity detecting the E key?
video3: Observation: The video shows how to set up a project folder and start a dated log to track work from the beginning.

Useful idea and interpretation: For my solo project, I can keep my notes and screenshots organized in Week12/Week12A and use a short log to record what I changed and tested. That way, I can pick up where I left off the next time I open the project.

Question: What should I put in my project log, and what should go in my README?
video4: Observation: The video shows how a one-page game design document can use a diagram and short labels to explain how a game mechanic works.
Useful idea and interpretation: For my solo Unity project, I could sketch the beacon interaction on one page: walk into range, press E, and see the beacon activate. This would help me explain the mechanic and decide what to test.
Question: Should I include what happens when the player presses E outside the beacon’s range, or keep the diagram focused on successful activation?
video5: Observation: The Hierarchy lists the objects in the scene. When I select an object, the Inspector shows its components and settings. The Scene view is where I edit the scene, and the Game view shows what the player sees.

Useful idea and interpretation: For my solo project, I can select the beacon in the Hierarchy, check its settings in the Inspector, and then use the Game view to test what the player sees when pressing E near it.

Question: If I change the beacon’s settings in the Inspector during Play Mode, will those changes still be there when I stop the game?
video6: Observation: The video shows how to import a 3D character model into Unity and explains that a prefab is a reusable template for a GameObject.

Useful idea and interpretation: For my solo Unity project, I could give the Explorer a custom look while keeping its existing movement and beacon interaction. After swapping the model, I would test both behaviors again.

Question: How can I replace the player’s model without changing its movement script or collider?
opinion: I can use this pipeline to build on my Week 11B story, where the Explorer restores communication by activating a beacon. My goal is to make it clear when communication has been restored. I would reuse my Explorer and Beacon, set up a message in the Game view, and test what happens when I press E both inside and outside the beacon’s range. Then I would record the results in my README so I can repeat the test after making changes.
questions: I’m working solo and plan to build on my Week 11B Explorer and Beacon scene.

1. Can I reuse my existing Explorer and Beacon and import a small environment for the Explorer to move through?
2. What should I check after importing the environment to make sure the Explorer can move through it and still activate the beacon?
3. What evidence should I include for Action 12B: screenshots, a short video, or test notes in my README?

# prepBoard
notes: My diagram connects the development pipeline to my solo Explorer and Beacon project. I will organize the assets, configure the scene, and test movement and beacon activation. Pressing E outside the interaction range should not activate the beacon, while pressing E inside the range should activate it. I will record the actual results and screenshots in my README.

# pitch
understand: My job is to build a small Unity scene where the Explorer can move through an imported environment and reach the Beacon. I will organize the assets, check movement and collisions, and test beacon activation inside and outside its interaction range. The work is complete when the scene runs as intended, the test results are documented, and the project files and evidence are uploaded to my personal GitHub repository.
offer: I’m working solo, so I will handle scene setup, importing and organizing environment assets, and testing the Explorer’s movement and Beacon interaction. I will also document the results, capture screenshots, and upload my work to my personal GitHub repository.
limits: I still need practice importing environment assets into Unity and checking their scale and colliders. I also need to learn how to replace the player’s model without breaking movement and how to display the Beacon’s activation message in the Game view. I will use tutorials, test one change at a time, and ask the instructor for help if I get stuck.
availability: 
Preferred contact: Classroom
I’m working solo during the CS110 class session. I will use this time to plan my scene, organize assets, and prepare tests. I can ask the instructor questions in class.
tools: I will use Unity to build the scene, import environment assets, and test the Explorer’s movement and Beacon interaction. I will use VS Code to edit C# scripts and write README notes. Git will track my changes, and GitHub will store my project and evidence so the instructor can access them. I will use screenshots to document my test results.
aiTool: AI: ChatGPT
Task: Help me plan my solo Unity project, explain C# code, and suggest troubleshooting steps and test cases for Explorer movement and Beacon interaction.
Verification: I will review and explain any suggested code, test changes in Unity, check the Console for errors, and compare expected and actual results. I will test Beacon interaction both inside and outside its range and document the results.

# availability
notes: I’m working solo during the CS110 class session. I will use this time to plan my scene, organize assets, and prepare tests. I can ask the instructor questions in class.

# aiPlan
name: ChatGPT
task: Help me plan my solo Unity project, explain C# code, and suggest troubleshooting steps and test cases for Explorer movement and Beacon interaction.
verify: I will review and explain any suggested code, test changes in Unity, check the Console for errors, and compare expected and actual results. I will test Beacon interaction both inside and outside its range and document the results.

# huddle
mission: Explorer Beacon — Solo Mission: The Explorer is stranded and must reach a beacon to restore communication. I will build a small Unity scene with an imported environment that the player can move through. The playable goal is to reach the Beacon and press E within its interaction range to activate it. A visible “Communication restored” message will confirm success. Pressing E outside the range should not activate the Beacon.
framework: I will use ADD/P2P to guide my solo project. For ADD, I will focus on one clear task at a time and use visible instructions and feedback so the player understands what to do. For P2P, I will connect the story goal to organized assets, Unity setup, testing, and documentation. I will keep the scope small: move through the environment, reach the Beacon, and press E to restore communication. I will use test results to decide what needs fixing before adding more features.
pipeline: Unnamed stage
Explorer Beacon — Solo Mission
Owner for all tasks: An Nguyen
1. Goal: Reach Beacon and restore communication
2. Inputs: Existing Explorer, Beacon, environment asset
3. Setup: Import environment; check scale and colliders
4. Build: Add visible instructions and success message
5. Test: Movement; E outside range; E inside range
6. Output: Saved Unity scene, screenshots and test notes
7. Handoff: Push source and documentation to GitHub
Plan: Setup → Build → Test → Document
Target: Complete and verify during Action 12B
I am responsible for every task in this solo project. The environment must be imported and configured before I test movement. Beacon activation must work before I test the success message. I will record actual results and fix failed tests before uploading the source and evidence to GitHub. If importing assets takes too long, I will use a smaller environment and keep the same playable goal.
tech: I will use Unity and C# to build Explorer Beacon — Solo Mission, and Visual Studio Code to edit scripts. I will reuse my existing Explorer and Beacon and import a small environment asset. I chose these resources to keep the scope manageable and focus on movement and beacon interaction. Git and GitHub will store the source, README, screenshots and test notes. As the solo owner, An Nguyen will check asset scale, colliders, Console errors, player movement and E interaction inside and outside the beacon range.
code: Classes & components
Class | Responsibility | GameObject
Existing player movement script | Read movement input and move the Explorer | Explorer
Beacon interaction script (planned) | Detect the Explorer in range, allow E to activate the beacon | Beacon
Success message script (planned) | Show "Communication restored" after activation | Canvas/SuccessMessage

Variables / properties
Name : type | Value / purpose | Used by
player : Transform | Reference to the Explorer; used to check distance | Beacon interaction script
interactionRange : float | Planned: 3 units; maximum activation distance | Beacon interaction script
isActivated : bool | Initially false; becomes true after valid activation | Beacon interaction script
successMessage : GameObject | Reference to the UI message; hidden until success | Success message script

f(x) · Functions
Function | Inputs → result | When called
IsPlayerInRange() : bool | Player position + beacon position → true if within interactionRange | Before allowing activation
ActivateBeacon() : void | Valid interaction → set isActivated to true and call ShowSuccess() | When E is pressed in range and the beacon is not activated
ShowSuccess() : void | ShowSuccess() : void |  After successful beacon activation

Start / Update
Callback | What happens | Verified
Start() | Set isActivated to false and hide the success message at scene start. | [x]
Update() | Check for E input. If the Explorer is in range and the beacon is not activated, call ActivateBeacon() | [x]

Packages / using
Package / namespace | Why included | Tested
using UnityEngine; | Provides MonoBehaviour, Transform, GameObject and Vector3 for checking distance, controlling beacon activation and showing the success message. | [x]
communication: Working agreements
Agreement | Owner / where recorded | Confirmed
Work solo and keep the scope to movement, beacon activation and a success message. | An Nguyen / course plan | [x]
Review progress at the start and end of each work session. | An Nguyen / README work log | [x]
Test changes and record actual results before marking tasks complete. | An Nguyen / TestNotes.md | [x]
Save decisions in the README and commit and push source and evidence after each work session |  An Nguyen / GitHub Week12/Week12A | [x]
reuse: I plan to reuse the Explorer player, Beacon interaction and success message in later story scenes. The scene setup and test checklist can also support future missions. I will keep reusable scripts and prefabs organized and document their setup in the README. For imported assets, I will record the creator, source link and license, follow reuse requirements and include required credits. I will also document AI assistance and verify any suggested code before using it.

boardNotes: I decided to work solo on Explorer Beacon — Solo Mission. I will reuse the Explorer and Beacon, import a small environment and add visible instructions and a success message. An Nguyen owns all tasks. The planned pipeline is Setup → Build → Test → Document. I will test movement, E outside the interaction range and E inside the range. I will keep the pipeline, decisions and open questions on the huddle board and copy key decisions into the README. There are no team disagreements because I am working solo. Open questions: Which environment asset fits the project, and what interaction range works best? I will resolve these through asset review and Unity testing.

# huddleBoard
notes: Explorer Beacon — Solo Mission. An Nguyen owns all four stages. The goal is to reach the beacon and press E within range to restore communication. Setup must be completed before building and testing. I will record actual test results and fix failures before documenting the outcome. Open questions are the environment asset choice and the best interaction range.

# pipelineBoard
notes: I am responsible for every task in this solo project. The environment must be imported and configured before I test movement. Beacon activation must work before I test the success message. I will record actual results and fix failed tests before uploading the source and evidence to GitHub. If importing assets takes too long, I will use a smaller environment and keep the same playable goal.

# codeTables

## 0
id: 227a06c4-e7d6-4b19-9547-a8bed12690ce
title: Classes & components

### columns

#### 0
label: Class
type: text

#### 1
label: Responsibility
type: text

#### 2
label: GameObject
type: text

### rows

#### 0
0: Existing player movement script
1: Read movement input and move the Explorer
2: Explorer

#### 1
0: Beacon interaction script (planned)
1: Detect the Explorer in range, allow E to activate the beacon
2: Beacon

#### 2
0: Success message script (planned)
1: Show "Communication restored" after activation
2: Canvas/SuccessMessage

## 1
id: 3c3be2e5-8396-426d-8677-03a52a63e2ca
title: Variables / properties

### columns

#### 0
label: Name : type
type: text

#### 1
label: Value / purpose
type: text

#### 2
label: Used by
type: text

### rows

#### 0
0: player : Transform
1: Reference to the Explorer; used to check distance
2: Beacon interaction script

#### 1
0: interactionRange : float
1: Planned: 3 units; maximum activation distance
2: Beacon interaction script

#### 2
0: isActivated : bool
1: Initially false; becomes true after valid activation
2: Beacon interaction script

#### 3
0: successMessage : GameObject
1: Reference to the UI message; hidden until success
2: Success message script

## 2
id: 7d25f6f6-30fc-47fc-9b3d-56635e12ebc0
title: f(x) · Functions

### columns

#### 0
label: Function
type: text

#### 1
label: Inputs → result
type: text

#### 2
label: When called
type: text

### rows

#### 0
0: IsPlayerInRange() : bool
1: Player position + beacon position → true if within interactionRange
2: Before allowing activation

#### 1
0: ActivateBeacon() : void
1: Valid interaction → set isActivated to true and call ShowSuccess()
2: When E is pressed in range and the beacon is not activated

#### 2
0: ShowSuccess() : void
1: ShowSuccess() : void
2:  After successful beacon activation

## 3
id: 860a33d9-fbc7-47fc-a0a9-554da45fcd9f
title: Start / Update

### columns

#### 0
label: Callback
type: text

#### 1
label: What happens
type: text

#### 2
label: Verified
type: checkbox

### rows

#### 0
0: Start()
1: Set isActivated to false and hide the success message at scene start.
2: true

#### 1
0: Update()
1: Check for E input. If the Explorer is in range and the beacon is not activated, call ActivateBeacon()
2: true

## 4
id: 6a3ea69e-9a04-4aa2-8543-36512de2c09c
title: Packages / using

### columns

#### 0
label: Package / namespace
type: text

#### 1
label: Why included
type: text

#### 2
label: Tested
type: checkbox

### rows

#### 0
0: using UnityEngine;
1: Provides MonoBehaviour, Transform, GameObject and Vector3 for checking distance, controlling beacon activation and showing the success message.
2: true

# communicationTables

## 0
id: 21048ced-b4cd-47d5-9547-4786df1eb5c9
title: Working agreements

### columns

#### 0
label: Agreement
type: text

#### 1
label: Owner / where recorded
type: text

#### 2
label: Confirmed
type: checkbox

### rows

#### 0
0: Work solo and keep the scope to movement, beacon activation and a success message.
1: An Nguyen / course plan
2: true

#### 1
0: Review progress at the start and end of each work session.
1: An Nguyen / README work log
2: true

#### 2
0: Test changes and record actual results before marking tasks complete.
1: An Nguyen / TestNotes.md
2: true

#### 3
0: Save decisions in the README and commit and push source and evidence after each work session
1:  An Nguyen / GitHub Week12/Week12A
2: true

# tasks

## 0
id: 785702e5-9472-4bf3-a639-ca522e7e35f3
task: Review the plan and create the README and task checklist
owner: PERSON-B3E6361FBFC025993B36C688
due: 2026-11-12T20:30
done: false
result: 

## 1
id: a9248e6a-4ddb-4b4e-bf2b-42f9c5073d45
task: Open the Unity project and organize asset folders
owner: PERSON-B3E6361FBFC025993B36C688
due: 2026-11-12T20:30
done: false
result: 

## 2
id: 7496d90e-d591-4ff5-b403-33a10e5dcecd
task: Import a small environment; check scale and colliders
owner: PERSON-B3E6361FBFC025993B36C688
due: 2026-11-12T20:30
done: false
result: 

## 3
id: d56b2477-0671-4434-b90b-f3fbc4d1050d
task: Import or reuse the custom Explorer player; check movement and camera
owner: PERSON-B3E6361FBFC025993B36C688
due: 2026-11-12T20:30
done: false
result: 

## 4
id: a1383a39-7df1-4839-8abf-12ebf2756be5
task: Configure Beacon interaction, instructions and success message
owner: PERSON-B3E6361FBFC025993B36C688
due: 2026-11-12T20:30
done: false
result: 

## 5
id: 9dc37925-d7b2-4f45-96bf-056ae0495609
task: Test movement, E outside range and E inside range; fix failures
owner: PERSON-B3E6361FBFC025993B36C688
due: 2026-11-12T20:30
done: false
result: 

## 6
id: 9a190563-c4e3-40cd-94c0-0d009ef06d56
task: Save screenshots, actual test results, asset credits and setup instructions
owner: PERSON-B3E6361FBFC025993B36C688
due: 2026-11-12T20:30
done: false
result: 

## 7
id: a547b1ae-298f-4269-b318-a5f07effea10
task: Handoff: commit and push source and documentation; verify GitHub files
owner: PERSON-B3E6361FBFC025993B36C688
due: 2026-11-12T20:30
done: false
result: 
returnToB: true
workNotes: I opened ExplorerBeacon12B in Unity and tested it in Play Mode. The Explorer could move through the imported outpost, and the walls blocked movement. Pressing E at the starting point left the beacon inactive. After I walked closer and pressed E again, the beacon changed color and the Game view displayed “Communication restored.” The planned tests passed.

# reportB
execution: For my solo mission, I opened EngineProject/Assets/Scenes/ExplorerBeacon12B.unity in Unity and ran the scene in Play Mode. I used WASD to move the Explorer through the outpost. I pressed E at the starting point and the beacon stayed inactive. Then I walked closer and pressed E again. The beacon changed color, the Game view showed “Communication restored,” and Unity logged the activation. I used the README and test checklist to guide my testing. Codex helped prepare the Unity project, and I ran and checked the tests myself.
tests: Issue → fix → retest: Unity initially opened an empty Untitled scene. I opened Assets/Scenes/ExplorerBeacon12B.unity and checked that Explorer and Beacon appeared in the Hierarchy. I entered Play Mode and verified that the imported outpost and Explorer model appeared. I moved the Explorer with WASD.
Expected: Pressing E at the starting point should leave the beacon inactive. Pressing E near the beacon should activate it.
Observed: At the starting point, pressing E left the beacon inactive. After I walked closer and pressed E, the beacon changed color, the Game view displayed “Communication restored,” and the Unity Console logged the activation.
handoff: Explorer Beacon — Solo Mission (An Nguyen)

My GitHub repository is https://github.com/anguyen0344/CS-110. The project folder is Week12/Week12B, and the Unity source is in Week12/Week12B/EngineProject. The README.md explains how to run the scene and lists the asset credits. TestNotes.md documents the test cases.

To reproduce my test, open EngineProject in Unity, open Assets/Scenes/ExplorerBeacon12B.unity, and click Play. Move with WASD or the arrow keys. I tested pressing E both outside and inside the beacon’s range. Outside the range, the beacon did not activate. Inside the range, it activated and displayed “Communication restored.”

I reused my Week 11B project. Codex helped prepare the scene, assets, and documentation, and I ran the tests in Unity myself.
reflection: My goal was to let the player explore the outpost and restore communication at the beacon. I tested ExplorerBeacon12B.unity in Play Mode and verified that the player could move through the scene. Pressing E outside the beacon’s range did nothing. When I moved close and pressed E again, the beacon activated and displayed “Communication restored.” My main takeaway was that testing both inside and outside the range confirmed that the range check worked, not just that the E key worked. I still need to verify that the project opens from a fresh GitHub download. My next step is to follow the README from that download and repeat both interaction tests.

# reportBBoard
notes: I tested the Explorer Beacon scene in Unity Play Mode. Pressing E outside the beacon’s range did nothing. After I moved closer and pressed E again, the beacon activated and displayed “Communication restored.” These two tests show that the beacon only responds when the player is close enough.