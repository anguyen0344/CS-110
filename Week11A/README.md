## Base behavior tests

### Predictions
- Speed 0: The cube will stop moving but continue rotating.
- Speed 2: The cube will move twice as fast as Speed 1.
- Red tint: The cube will turn red when I restart Play mode.

### Observed results
- At Speed 0, the cube stopped moving.
- At Speed 2, the cube moved faster than at Speed 1.
- After changing Tint to red and restarting Play mode, the cube turned red.

### What I learned
Update() runs every frame. Multiplying Speed by Time.deltaTime
calculates movement based on elapsed time.
The color is applied in Start(), so I changed Tint while stopped
and restarted Play mode to see the new color.

### Evidence
- [Speed 0](Evidence/BaseTests/speed-0.png)
- [Speed 2](Evidence/BaseTests/speed-2.png)
- [Red tint](Evidence/BaseTests/tint-red.png)

## Extension: Stop at a boundary

Question: Can the cube stop moving at X = 3 while continuing to rotate?

Prediction: At Speed 1, it will reach X = 3 in about three seconds.

Change: I added StopAtBoundary.cs to MyMarker in a separate scene.

Difficulty: I first attached the script to a separate object.
I fixed this by attaching it to MyMarker.

Result: The cube stopped at X = 3 and continued rotating.

What I learned: GetComponent<TranslateObject>() looks for the
movement component on the same GameObject.

Evidence: [Boundary test](Evidence/Extension/boundary-stop.png)

## Prefab and two instances

I saved MyMarker as a prefab and created a second instance.
The first instance had Speed 1, and the second had Speed 2.
The second cube moved faster.

Each instance has its own state, even though both use the same
prefab setup. A prefab does not automatically pool or delete
instances. More live instances can require additional runtime
memory and processing.

Evidence: [Two instances](Evidence/BaseTests/two-instances.png)


## C# concepts and engine translation

- Class: A definition of data and behavior, such as TranslateObject.
- Object: An instance of a class. Each cube has its own TranslateObject component.
- Field: speed stores the movement rate.
- Property: Speed provides get/set access to speed.
- Method: A function that performs work.
- Callback: Unity calls Update() every frame.
- Engine API: transform.Translate() changes the object's position.

In Action 10B, my Greeting class returned a message that
Console.WriteLine() displayed. In 11A, Unity calls Update(),
and my script changes a visible object's Transform.

Time.deltaTime is the elapsed time for a frame.
Multiplying it by Speed turns a rate per second into
the distance to move during that frame.

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

 ## Team debrief

My discovery: Speed 0 stopped the cube’s movement, while Speed 2
made it move faster.

My difficulty: I initially attached StopAtBoundary to a separate
object. Attaching it to MyMarker fixed the problem.

My interpretation: Separate components make it easier to change
movement without changing rotation or color.

Possible team use: We can adjust Speed to control movement
and use a boundary to limit an object's position.
