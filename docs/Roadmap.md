---
layout: default
title: Roadmap
nav_order: 0
---

# Roadmap
## v1.2 Work List
###  Features
- Resistance to slopes. This setting will prevent the car from constantly sliding on slopes.
- Reverse acceleration and Reverse Turning Nerf to allow for better vehicle control when going in reverse.
- Make turning optional for drifting
- Tire Marks

### Bugs
- Disabling tick on the Vehicle crashes the engine

### Refactors
- Wheels offsets are currently computed in the VehicleSystem while this data is for the Animation Blueprint. To be more consistent with v1.1, the calculation of those offsets as wheel as their settings will be moved to the Animator component.
- Controller EnableMovement function will be renamed, its confusing and the function actually impacts inputs not movement.
- Cleaning up the animation blueprint, there's two right now which a little confusing as they are mostly the same except that the basic one does not have drift rotation tilt and roll.

## Big Items
- Networking (status **[here!](./v11_update.html)**)
- Improving the Animator (cleaner API and better Tilt and Roll animations when spamming buttons.)
- Better demo map