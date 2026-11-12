# Action 12B — Explorer Beacon: Solo Mission
Owner: An Nguyen

Open EngineProject in Unity Hub using the version in ProjectSettings/ProjectVersion.txt. After import, open Assets/Scenes/ExplorerBeacon12B.unity and press Play. Use WASD or arrows to walk to the beacon. Press E within 3 units to restore communication. The level model and Explorer shell are imported OBJ assets loaded in Play Mode; the original player controller and beacon behavior come from Week11B.

## Video 1–6 workflow
1. Define one playable outcome: reach and activate the beacon.
2. Change one thing at a time; use the test notes to record failures and fixes.
3. Keep scene, scripts, models and project settings organized.
4. Use the 12A design and pipeline boards as the implementation plan.
5. Open the mission scene in Unity; inspect Explorer and Beacon, then check Game view.
6. The scene reuses the Week11B Explorer controller and loads an imported custom visual model as a child during Play. Verify controls, collision and camera.

## Credits
Explorer controller and Beacon: An Nguyen's Week11B project (StoryScene11B).
Outpost and Explorer shell: original OBJ meshes generated with Codex for this project; no third-party model assets added.
Codex assisted with the source changes, models and documentation. Runtime verification is pending on a machine with Unity.

## Handoff
Run TestNotes.md, record actual outcomes, and add screenshots of Game view before and after activation. Put this Week12B folder under Week12 in CS-110. Keep Assets, Packages and ProjectSettings; exclude Unity caches. Add the issued course report and personal public VIEW code as instructed on the course page. Commit, push, verify GitHub and submit the repository link and public VIEW code in Canvas.
