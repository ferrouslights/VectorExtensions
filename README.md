# VectorExtensions
A set of Vector2, Vector3, and Vector4 extensions for added channel swapping between xyzw/rgba similar to HLSL float2, float3, and float4's.

## How to use
 - Import the source folder into your project and include the namespace ```ferrouslights.VectorExtensions```
 - On a Vector2, Vector3, or Vector4, you should have access to their extension methods for accessing and mix/matching channels.
 
## Example
 - For a Vector3 with an xyz of (0,1,2), calling ```Vector3.xy()``` will return a Vector2 of (0,1)
 - You can also swap which channels come first, for example ```Vector3.zx()``` will return a vector2 of (2,0)
 
 Please star if you found this helpful or feel free to add feature requests for this! 
