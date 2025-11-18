# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
Because the height of the ball's rebound cannot be precisely represented by an integer of the int type, and since bool values represent either true or false, and str values represent text, none of these options are suitable for expressing the digital height. The float type can precisely represent the exact height of the rebound, making it the most suitable type. It is most appropriate to use the integer type for the number of rebounds, because the number of rebounds cannot be a decimal. Just as it is impossible for a ball to rebound 4.6 times. And neither the bool value nor the str value can represent the number of rebounds.

### W3
Table6  I will set the input as the time when the player hits the screen, and the output will be the difference between the player's hitting time and the beat.
Class Just like an architectural design blueprint, it defines the structure, function and layout of the house, but it is not the house itself. You can use this blueprint to build many houses. Component is a specific house built according to the blueprint. Although they all follow the same design, each house can have different colors, furniture, occupants, etc. Member's variables This refers to the specific features of each house. It's like saying that a house has several windows. Methods refers what the house could do, like you can sleep in the house and control the lights on and off.

### W4 
Table 8. line5 defines a float value called moved_speed and it's value is 1.0f. The code enables the character to move forward and backward along the Z-axis when the W/S keys are pressed, with the speed controlled by _moveSpeed, and the movement is frame rate independent. The character will begin to move in the sprite (0.0) due to line 25.
I change the cat and the soccer ball object with a rigid body because they need to collide. The Goal object don't has a rigid body but check if trigger. When I test the first time the cat falls underground. I change the clooider size and then fix it.

### W5
"How does the Transform component's forward vector differ from Vector3.forward, and when should I use one over the other in player movement or raycasting?"
Transform.forward is a dynamic vector that represents the forward direction of a game object in world space, changing as the object rotates—perfect for movement or raycasting based on the object’s orientation. In contrast, Vector3.forward is a constant vector equal to (0, 0, 1), always pointing in the world’s Z-axis direction regardless of rotation.
The DeerW5 class needs two member variables: a public Transform targetTransform that can be set in the Inspector to define the GameObject the deer should walk toward, and a private NavMeshAgent agent to control movement. It should use Unity’s Start() method to initialize behavior. In Start(), the class will use GetComponent<NavMeshAgent>() to access the agent on the deer GameObject and then call agent.SetDestination(targetTransform.position) to begin walking toward the target.

### W6
https://docs.google.com/document/d/1jGkW1Q2xP_713KL3rIzM0yPQ_F7CGMHJ1AHQlTPs5pg/edit?tab=t.0
I, along with two other classmates, completed the "Other Tools" and "Math" sections.
Note:
This class requires two variables. The first one is _speed, which is used to control the speed at which the bat moves.
* It is a floating-point number (float). The second one is _target, which is used to store the target to be chased,
* that is, the Transform of the cat. Both of these variables are marked with [SerializeField].
* This class requires four methods. Two of them are provided by Unity: Start() and Update(). These two methods must be preceded by the "public" keyword so that BatManager can call them. The Start() method disables the script (enabled = false) when the game starts,
* so that the bat won't chase the player at the beginning. The Update() method checks if the target exists,
* and then uses Vector3.MoveTowards to make the bat move a little bit towards the target in each frame.
* The StartChasing() method enables the script (enabled = true), so that Update() starts running,
* and the bat begins to chase. The StopChasing() method disables the script (enabled = false),
* so that Update() stops running and the bat stops chasing.

### W7
https://docs.google.com/document/d/1Ijdci9okeeCyicXsW5tH1rMqU_g65RI7T5syzvF4jAY/edit?tab=t.0
Vector3.forward represents the Z-axis direction in world space, not the "forward" direction of Muskrat itself. If Muskrat has been rotated (for example, while walking on a bubble), its "forward" direction may not be the world's Z-axis.

### W8
https://docs.google.com/document/d/1aQQfBJetK0YUJICSMPK56GtJ9ZsKjf_5JssGeMr1a4Q/edit?tab=t.0
I wrote part of the system part and plan part.
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
