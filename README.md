# AlienVsPredatorVisionModes

Project has Night Vision,thermal vision and EM vision implemented

## Working

In the project,Assets/VisionModes folder has all assets for the  vision modes.
You can drag drop Assets/VisionModes\Prefabs\CameraVisionManager prefab into any scene to use these vision modes.
For quick testing, You can open Assets/VisionModes\Scene\mainVisionModes scene file to test vision modes.You can press 1,2,3,4 keys on the keyboard to switch between vision modes.

CameraVisionSystem mainly works on layers. You need to assign layers to your objects in the scene i.e. assigning 'Human' layer will let you see that object in thermal effect and assigning 'Alien' layer will let you see that object in EM vision effect.
Night vision shader's noise can be adjusted by setting noise parameter of the shader.

## Future Tasks

Currently project has vision modes working. but there is space for a lot of improvement.
Here are some improvements:

1- Currently there is no smooth transition when we switch from one vision mode to another. Smooth transition can be added <br/>
2- Currently Thermal effect render a red like colour for showing objects. Shader can be improved by adding heat maps  and noise in shader so that custom heatmaps can be defined for meshes to give more realistic thermal effect.<br/>
3- Currently EM vision effect render a green colour for showing objects. Shader can be improved by adding diffuse map and multiplying in with some intensities and colors to give better EM vision look in.<br/>
4- Currently Objects cannot be seen If there is an obstacle in between. So My overriding depth testing, thermal and diffuse shader can be improved to see objects through obstacles like wall or door etc.<br/>
5- Currently CameraVisionManager used many cameras to render vision modes. The number of cameras can be minimized with a little refactor. <br/>



Time spend: 8 hours