# Unity WebGL Build Guide: Playing Your Game in a Browser

This guide will walk you through the process of building your Unity project into a WebGL format, which allows it to be played directly in a web browser.

## 1. Install the WebGL Build Support Module

Before you can build for WebGL, you need to make sure the necessary module is installed for your version of the Unity Editor.

1.  **Open Unity Hub.**
2.  Go to the **Installs** tab on the left.
3.  Find the version of the Unity Editor you are using for your project.
4.  Click the **gear icon** next to it and select **Add Modules**.
5.  In the list of modules, find **"WebGL Build Support"** and make sure its checkbox is ticked.
6.  Click **"Install"** and wait for the download and installation to complete.

## 2. Switch the Build Platform in Unity

1.  With your project open in the Unity Editor, go to `File -> Build Settings...`.
2.  In the `Platform` list on the left, select **WebGL**.
3.  Click the **"Switch Platform"** button at the bottom right. Unity will re-import some of your assets to conform to the WebGL platform, which might take a few minutes.

## 3. Configure WebGL Player Settings (Optional but Recommended)

1.  In the `Build Settings` window, click the **"Player Settings..."** button. This will open the Project Settings window with the Player section selected.
2.  Under the **"Publishing Settings"** section, you can choose a `Compression Format`.
    *   **Gzip (Default):** Offers good compression and is widely supported.
    *   **Brotli:** Offers better compression (smaller file sizes) but might take slightly longer to build. For web games, smaller is often better, so Brotli can be a good choice.
    *   **Disabled:** No compression. This will result in very large files and is not recommended for web deployment.
3.  You can also configure other settings here, like the game's resolution and presentation, just as you would for a standalone build.

## 4. Build the Game

1.  Once you've switched the platform to WebGL, go back to the `Build Settings` window (`File -> Build Settings...`).
2.  Click the **"Build"** button.
3.  A file dialog will appear. **It is very important that you create a new, empty folder for your build.** For example, you could create a folder named `WebGL_Build` inside your project's main directory.
4.  Select this new folder and click **"Select Folder"**.
5.  Unity will now begin the build process. Building for WebGL can take significantly longer than building for standalone, so be patient.

## 5. Understanding the Output

When the build is complete, you will find several files and folders inside the build folder you selected. The key components are:

*   **`index.html`:** This is the HTML file that you open in a browser to run the game. It contains the canvas that the game will render on.
*   **`Build/` folder:** This contains the core data and code for your game, often in `.gz` or `.br` compressed formats.
*   **`TemplateData/` folder:** This contains the visual template for the loading screen and the `index.html` page.

You can test your build locally by opening the `index.html` file in a browser. However, due to browser security restrictions, some browsers may not run the game correctly from a local file (`file:///...`). The best way to test it is to upload it to a web server, which is what we'll cover next.
