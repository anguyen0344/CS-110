## Borrowed capability and code concepts

- Package: Unity Input System (`com.unity.inputsystem`), version 1.20.1.
- Source: Unity Registry.
- Reused code: PlayerMover.cs and StoryBeacon.cs from the CS110 Action 11B worked example.
- My work: scene setup, component connections, configuration, and testing, including changing Speed from 3 to 5.

The package supplies reusable input code. `UnityEngine.InputSystem` is a namespace that organizes its types. `Keyboard` is a type, and `Keyboard.current` provides access to the current keyboard.

`using UnityEngine.InputSystem;` lets my script refer to names such as `Keyboard` without writing the full namespace. It does not install the package or create a component instance.

`PlayerMover` is a class. The PlayerMover attached to Explorer is a component instance. Its serialized `speed` field stores movement speed, and the `Speed` property provides access to that value. The Inspector edits the field directly.

Unity calls `Update()` each frame. It reads keyboard input and moves Explorer through `CharacterController.SimpleMove()`. Pressing E within `interactionRange` calls the referenced StoryBeacon instance’s `Activate()` method.

`IsActivated` prevents repeated activation. A MaterialPropertyBlock changes Beacon’s visible color without modifying its shared material asset.