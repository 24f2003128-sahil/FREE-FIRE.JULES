# Unity Build Guide: Sharing Your Game

This guide explains how to build your Unity project into a standalone application (e.g., a `.exe` file on Windows) that you can zip and share with others.

## 1. Open Build Settings

1.  In the Unity Editor, go to the top menu and select `File -> Build Settings...`. This will open the Build Settings window.

## 2. Configure the Build

1.  **Scenes In Build:** At the top of the window, you'll see a list of "Scenes In Build," which is probably empty. Your current scene needs to be added to the build. Click the `Add Open Scenes` button. You should see your current scene (e.g., `Assets/Scenes/SampleScene.unity`) appear in the list with a checkmark next to it.
2.  **Platform:** On the left side, you'll see a list of platforms you can build for (PC, Mac, Linux, iOS, Android, etc.). Select the platform you want to build for. For sharing with friends on desktop, `PC, Mac & Linux Standalone` is the best choice.
3.  **Target Platform:** After selecting the main platform, you can choose a specific operating system from the `Target Platform` dropdown (e.g., `Windows`, `macOS`, `Linux`).
4.  **Architecture:** You can usually leave the `Architecture` as the default (e.g., `x86_64` for Windows).

## 3. (Optional) Player Settings

1.  At the bottom of the Build Settings window, there is a `Player Settings...` button. This opens a new window where you can configure many aspects of your game, such as:
    *   **Company and Product Name:** Set the name of your company and the name of your game.
    *   **Icon:** Set the icon for your game's executable.
    *   **Resolution and Presentation:** Choose whether you want the game to start in fullscreen or windowed mode, and set the default resolution.

## 4. Build the Game

1.  **Click "Build":** Once you're ready, click the `Build` button in the Build Settings window.
2.  **Choose a Location:** A file dialog will appear, asking you where you want to save the build. It's highly recommended to create a new folder for your build outside of your main project's `Assets` folder. For example, you could create a folder named `Builds` next to your project folder.
3.  **Name and Save:** Give your build a name and click `Save`. Unity will now start the build process. This can take a few minutes.

## 5. Share the Game

1.  **Find the Build Folder:** Once the build is complete, navigate to the folder you selected in the previous step.
2.  **Zip the Folder:** You will see a `.exe` file (on Windows) and a `Data` folder. **Both are required to run the game.** To share your game, you need to send the entire folder. The easiest way to do this is to right-click the folder, and choose `Send to -> Compressed (zipped) folder`.
3.  **Send the Zip File:** You can now share this single `.zip` file with anyone. They will need to unzip it on their computer and then double-click the executable to play your game.
