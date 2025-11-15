# Unity Setup Guide: From Scripts to a Playable Scene

This guide will walk you through the essential steps to take the C# scripts we've created and set them up in the Unity Editor to create a simple, playable game scene.

## 1. Setting Up Your Unity Project

1.  **Open Unity Hub** and create a new **3D** project.
2.  **Import Scripts:** Once the project is open, find the `Assets` panel (usually at the bottom of the editor). Right-click inside it, select `Create -> Folder`, and name it `Scripts`.
3.  **Drag and Drop:** Drag the four C# files (`PlayerController.cs`, `Weapon.cs`, `Health.cs`, `EnemyAI.cs`) from your file explorer directly into this new `Scripts` folder in Unity. Unity will automatically compile them.

## 2. Creating the Player

1.  **Create a Player Object:** In the `Hierarchy` panel (usually on the left), right-click and choose `3D Object -> Capsule`. Rename this object to `Player`.
2.  **Add a Rigidbody:** Select the `Player` object. In the `Inspector` panel (on the right), click the `Add Component` button at the bottom. Search for `Rigidbody` and add it. This component allows your player to be affected by physics (like gravity).
3.  **Attach PlayerController Script:** With the `Player` still selected, find the `PlayerController.cs` script in your `Assets/Scripts` folder and drag it onto the `Inspector` for the `Player`. You will see its public variables (`Move Speed`, `Jump Force`) appear. You can adjust these values here.
4.  **Position the Camera:** The default `Main Camera` is separate. To make it follow the player's view, drag the `Main Camera` object in the `Hierarchy` onto the `Player` object. This makes it a child of the player. Reset the camera's `Transform` component in the Inspector (click the three dots and select `Reset`). Then, adjust its position so it's roughly where the player's eyes would be (e.g., `X: 0, Y: 0.6, Z: 0`).

## 3. Creating the Weapon

1.  **Attach Weapon Script:** Select the `Main Camera` in the `Hierarchy`. Drag the `Weapon.cs` script from your `Assets/Scripts` folder onto the `Inspector` for the `Main Camera`.
2.  **Assign Camera Reference:** The `Weapon` script has a public field called `Fps Cam`. It needs a reference to the camera it's shooting from. Since the script is *on* the camera, you can just drag the `Main Camera` object from the `Hierarchy` into this `Fps Cam` slot in the Inspector.

## 4. Building the Environment

1.  **Create a Ground Plane:** In the `Hierarchy`, right-click and choose `3D Object -> Plane`. Rename it `Ground`.
2.  **Scale the Ground:** Select the `Ground` object. In its `Transform` component in the `Inspector`, change the `Scale` values to something larger, like `X: 20, Y: 1, Z: 20`, to give yourself room to move.
3.  **Tag the Ground:** This is a crucial step for the jump mechanic to work. Select the `Ground` object. At the top of the `Inspector`, you'll see a `Tag` dropdown, which is probably set to `Untagged`. Click it, select `Add Tag...`, click the `+` icon, name the new tag `Ground` (case-sensitive!), and save it. **Then, re-select the `Ground` object and change its `Tag` to the new `Ground` tag.**

## 5. Creating an Enemy

1.  **Create an Enemy Object:** In the `Hierarchy`, right-click and choose `3D Object -> Cube`. Rename it `Enemy`.
2.  **Position the Enemy:** Move the `Enemy` cube so it's sitting on the `Ground` plane and is in front of the player's starting position.
3.  **Attach Health Script:** Select the `Enemy` object. Drag the `Health.cs` script onto its `Inspector`. You can set its `Max Health` here.
4.  **Attach EnemyAI Script:** Select the `Enemy` object again and drag the `EnemyAI.cs` script onto its `Inspector`.

## 6. Play the Game!

You're all set! At the top-center of the Unity Editor, press the **Play** button (a triangle icon). You should now be able to:
- Move around with `W`, `A`, `S`, `D`.
- Jump with the `Spacebar`.
- Aim with the mouse.
- "Shoot" the enemy cube by clicking the left mouse button. To see the effect, look at the console window (`Window -> General -> Console`) where the `Debug.Log` from the `Weapon` script (before we added the health system) would have shown the hit. Now, with the health system, shooting the cube will eventually deactivate it.
