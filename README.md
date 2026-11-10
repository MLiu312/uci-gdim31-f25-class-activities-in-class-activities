# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.
1: The camera is no longer tied to the cat object and thus does not follow it around, so the cat still moves but the camera is stuck at its starting position.
2: https://fayawizard.itch.io/w1

### W2
1. The r, g, b values are floats instead of ints, bools, or strings, because the RGB scale is set from 0 to 1, and thus increments in decimal values, and must be tracked through floats.

2. The _bounce variable is an int instead of a float, bool, or string since bounces will always be a number but never a decimal, and thus can simply be tracked through an integer.

3. Syntax error, it let me know that there was an expected semicolon at the end.

### W3
Table #2
1. String GetResponse(int choice, int friendshipLevel, bool secret)

2. void SetLightDimness(int sanityLevel)

3. bool DidPlayerHitBeat(float accuracy)

4. The metaphor we came up with is that the components are tacos from Taco Bell™, and classes are the individual taco shells that form a template for the taco from Taco Bell™ itself. The member variables and methods are the ingredients in the taco from Taco Bell™. 

5. The balls became extremely bright because their speed exceeded the average speed threshold, thus multiplying their color values by 1.5.

### W4
Table #4
1. I added RigidBodies to the cat and soccer ball, as both need to move, and an isTrigger to the goal, as it needs to trigger an event when the ball enters.

2. It worked properly the first time.

### W5
Henri was my partner for this in-class activity. The Deer class needed two variables, one SerializeField Transform variable called target to track the gameObject the Deer would move towards, and one private NavMeshAgent variable called agent, to get the component. This class would just have two methods, Start() and Update(), both provided by Unity. Start() would get the NavMeshAgent component and assign it to agent, while Update() would continually set the NavMeshAgent's destination towards the target object's position, using the SetDestination() method.

### W7

Activity 1: I did parts of Unity Engine and Unity Coding. Link: https://docs.google.com/document/d/1C6uCwfuqZOueFMv-xBgh9KSqakfdi0eeqCGhbDev6XM/edit?usp=sharing

Activity 2: Henri was my partner again

- What member variables does this class need?
  
This class needs a [SerializeField] private float variable _speed, and then two private variables, one Boolean chasing to track if the bats should chase, and Transform player, to track the player Object.

- What methods does this class need? Should it be something that Unity provides (like Start(), Update(), or a collision method), or one you write?
  
This class needs 3 methods, Update() which is provided by Unity, and then two methods we write ourselves, StartChase() and StopChase(). StartChase takes a Transform object and assigns that to the variable player and sets the boolean chasing to true, while StopChase sets the boolean chasing to false. In Update(), it will check if chasing is true, and if so, it will call MoveTowards to send the bat towards the player.
  
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
