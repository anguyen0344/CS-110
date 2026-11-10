
# Action 12A — Explorer Beacon: Solo Mission

**Name:** An Nguyen  
**Working arrangement:** Solo  
**Date:** November 10, 2026

## Mission

The Explorer is stranded and must reach a beacon to restore communication. I plan to build a small Unity scene with an imported environment. The player will move to the Beacon and press E within its interaction range. Successful activation will display “Communication restored.” Pressing E outside the range should not activate it.

## Current Status

Action 12A focuses on preparation and planning. Unity implementation and testing are planned for Action 12B. The planned features have not yet been verified.

## Preparation and Video Takeaways

1. Organize the project and maintain documentation throughout development.
2. Use small changes and test failures to guide improvements.
3. Keep assets, source files and work notes organized.
4. Use a visual game design document to communicate the playable goal.
5. Use the Hierarchy and Inspector to configure objects, and Game view to verify player feedback.
6. Import or reuse a custom player and check its components, movement and camera.

## Production Pipeline

Setup → Build → Test → Document → Handoff

- Setup: Organize folders, import the environment and configure the Explorer.
- Build: Configure Beacon interaction, instructions and success feedback.
- Test: Check movement and interaction inside and outside the activation range.
- Document: Record actual results, screenshots, setup instructions and credits.
- Handoff: Commit and push the source and evidence to GitHub.

## Task Plan

All deadlines below are planned for November 12, 2026, Pacific time.

| Task | Owner | Deadline |
|---|---|---|
| Review the plan and create the documentation checklist | An Nguyen | 12:55 PM |
| Open the Unity project and organize asset folders | An Nguyen | 1:10 PM |
| Import a small environment; check scale and colliders | An Nguyen | 1:30 PM |
| Import or reuse the Explorer; check movement and camera | An Nguyen | 1:50 PM |
| Configure Beacon interaction, instructions and success message | An Nguyen | 2:15 PM |
| Run tests and fix failures | An Nguyen | 2:40 PM |
| Save screenshots, test results, credits and setup instructions | An Nguyen | 2:55 PM |
| Commit, push and verify the GitHub handoff | An Nguyen | 3:05 PM |

## Planned Code and Engine Connections

| Component | Responsibility |
|---|---|
| Existing player movement script | Read movement input and move the Explorer |
| Planned Beacon interaction script | Check distance and allow E activation within range |
| Planned success message script | Display “Communication restored” after activation |

Planned data includes the player Transform, interactionRange, isActivated and a successMessage reference. The initial interaction range will be 3 units and may change after testing.

Start() will initialize the activation state and hide the success message. Update() will check interaction input. Planned functions include IsPlayerInRange(), ActivateBeacon() and ShowSuccess().

The scripts will use UnityEngine for Unity components, object references and distance calculations. Names and implementation details will be updated to match the actual code.

## Planned Tests

| Test | Expected result | Status |
|---|---|---|
| Move the Explorer | Player moves through the environment with appropriate collisions | Not yet tested |
| Press E outside range | Beacon remains inactive | Not yet tested |
| Press E inside range | Beacon activates and shows the success message | Not yet tested |
| Press E after activation | No repeated activation or errors | Not yet tested |
| Restart the scene | Beacon and success message return to their initial state | Not yet tested |
| Check the Console | No errors during the tested interactions | Not yet tested |

Actual results and fixes will be recorded in TestNotes.md.

## Decisions and Working Agreements

- Work solo; An Nguyen owns every task.
- Keep the scope focused on movement, one Beacon and clear success feedback.
- Reuse the existing Explorer and Beacon where appropriate.
- Review progress at the start and end of each work session.
- Mark tasks complete only after checking the result.
- Keep decisions in the course board and README.
- Commit and push source and evidence after each work session.

Open questions:
- Which small environment asset fits the project?
- What interaction range works best?

If importing the environment takes too long, I will choose a smaller asset and preserve the same playable goal.

## Reuse, Credits and AI Assistance

The player, Beacon interaction, success feedback and test checklist may be reused in later story scenes.

For imported assets, I will record the creator, source link and license and include required credits.

ChatGPT assisted with planning, organizing tasks and drafting documentation. Suggested code will be reviewed and tested before use.

## Submission Evidence

The submission includes the exported course reports and saved board evidence available in this folder.

My name and public VIEW code are recorded in PERSONAL-SUBMISSION-CODE.txt. Private recovery credentials are excluded from this repository.
