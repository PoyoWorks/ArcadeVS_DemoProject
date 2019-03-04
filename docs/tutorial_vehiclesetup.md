## Using your own Vehicle Mesh

Now that you have a basic understanding on how ArcadeVS works and that you've tested the defaults vehicle, its time to make your own :)

This document will detail the steps needed to prepare a Vehicle Skeletal Mesh and set it up properly to be used with an ArcadeVS vehicle.
For this Tutorial I'm going to use a nice low-poly 3D car model coming from [Synty Studios - Simple Racer Pack](https://www.unrealengine.com/marketplace/en-US/simple-racer)

### Mesh Setup

The first thing you will want, is to make sure that your Vehicle Mesh is a Skeletal Mesh. You Mesh has to be rigged, this is needed for the following reasons:
- The Suspension system will need Bones Locations to use as positions to shoot its raycasts and apply the suspension forces
- We want to use Animation Blueprints to animation the Wheels direction and rotation.

*If you've bought a 3D Vehicle Asset Packs, all the models will probably already be rigged and have their bones properly setup.*

### Physics Material Setup

Now that we've validated that our Mesh is properly rigged and its Bones properly oriented, we need to set its Physics Material. 

If your mesh already has a Physics Material assigned, go and Edit it. Otherwise, you can right click on your Skeletal Mesh in the Content panel and **Create->Physics Asset->Create and Assign**.

![](/assets/images/tut_vehicle_3.png)

Now, and this is important to understand, as the Suspension will all be done by using raycasts, we don't want to have any collision geometry for our wheels. We only want to have collision geometries for the body of the car. 

For example, here is how the car from the Synty's pack is setup:

![](/assets/images/tut_vehicle_4.png)

You can see that it has many physics body defined and has spheres for the wheels. We want to remove all those bodies and simply keep the physics body for the frame of the vehicle. 

Once this is done, the Physics Material for our Vehicle should look like this:

![](/assets/images/tut_vehicle_5.png)

### Creating the new Vehicle

Now that our Skeletal Mesh is ready, we can create a new Blueprint and select ArcadeVSVehicle as it's parent class.

![](/assets/images/tut_vehicle_2.png)

Double click the newly created Blueprint to edit it.

#### Adding the Visualizer

To make easier to see what we're doing and layer on fine tune our vehicle, we're going to directly add the Visualizer Component to our newly created Vehicle.

![](/assets/images/tut_vehicle_7.png)

The Visualizer will have all settings activated by default, which is fine as it will allow us to easily see our suspension setup.

#### Skeletal Mesh settings

The first thing to do is to set our new Skeletal Mesh as the Vehicle Skeletal Mesh. To do this, select the **VehicleSkeletalMesh** component in the **components panel** and assign your mesh to the **Skeletal Mesh parameter**. You should now see your Vehicle in the Viewport.

Now, we want to enable physics for our Vehicle. To do this, still with the **VehicleSkeletalMesh** component selected, tick **Simulate Physics** in the Physics settings and set the Collision Presets to **BlockAll** in the Collision settings. *Remember that Unreal will not simulate physics if you don't set a valid Collision Profile!*

Now if you hit the **Simulate** Button you should see your car falling down the screen.

#### Suspensions Settings

Now we need to setup the suspension system. To do this, select the Root Component of your Vehicle. You should now see all the ArcadeVS settings panel.
The first one being **ArcadeVS / Suspension**

In the first settings **Suspension Points Bone names**, hit the **+** button 4 times to create four entries, and enter the name of each wheel bone of your Skeletal Mesh. 
You should end up with something like this:

![](/assets/images/tut_vehicle_6.png)

#### First test

Now that our Mesh is setup and our suspension system is configured, we can do a first test. 

Make sure that you have a valid GameMode and that you have set your new Vehicle Actor as the Default Pawn Class for your GameMode and hit play!

(you can check [ArcadeVS Project Setup from scratch](tutorial_projectsetup) if you're unsure about how to do that)

If everything works correctly, you camera should be at the Origin and should see a part of your Vehicle. To validate, hit the *Eject* button *(make sure that you were testing in the Editor and not in Standalone mode or you won't be able to Eject)* and move the camera to look at your Vehicle.

You should see your vehicle resting above the ground and be able to see the Visualizer Raycast traces.

![](/assets/images/tut_vehicle_8.png)


### Camera Setup and System Tuning

Now that the basic setup is done we're going to transform this into a fully playable Vehicle.

- First we want to add a Spring Arm and a Camera to our Pawn so we have a nice view angle when playing. I'm not going to detail those steps and you're probably used to setting up those components if you're familiar with Unreal.
If that's not the case, you can check ArcadeVS default Vehicles and check their settings as they both have Cameras properly setup.
-


