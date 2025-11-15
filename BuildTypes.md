# Game Build Types: Standalone vs. WebGL

When you finish a stage of your game in Unity and want to share it, you need to "build" it. Building compiles all your code, assets, and scenes into a format that can be run outside the Unity Editor. There are two main types of builds we'll focus on: Standalone (for desktops) and WebGL (for web browsers).

## Standalone (Desktop) Build

This is the most traditional way to distribute a game.

*   **What it is:** A self-contained, executable application that runs directly on a computer's operating system.
*   **File Types:**
    *   On Windows, this is a `.exe` file (along with a `Data` folder).
    *   On macOS, this is a `.app` file.
    *   On Linux, it's an `.x86_64` file.
*   **How to Play:** The user downloads your game, unzips it, and double-clicks the executable to run it. It runs as a native application on their computer.
*   **Pros:**
    *   **Performance:** Generally offers the best performance and graphical quality because it has direct access to the computer's hardware.
    *   **Offline Access:** Once downloaded, no internet connection is needed to play.
    *   **No Browser Limitations:** Not restricted by browser memory limits or performance throttling.
*   **Cons:**
    *   **Installation Barrier:** Users have to download and trust a file, which can be a barrier for some.
    *   **Platform-Specific:** You have to create separate builds for Windows, macOS, and Linux.

## WebGL (Web Browser) Build

This allows you to embed your game directly into a webpage.

*   **What it is:** A version of your game that is compiled into JavaScript and WebAssembly, allowing it to run in modern web browsers that support WebGL.
*   **File Types:** A collection of files, including an `index.html` file, a `Build` folder, and a `TemplateData` folder. The `index.html` is the entry point that loads and runs the game.
*   **How to Play:** The user navigates to a URL in their web browser. The game loads and plays directly on the webpage, with no downloads or installation required.
*   **Pros:**
    *   **Instant Access:** The biggest advantage. Anyone with the link can play your game almost instantly. There's no download or installation friction.
    *   **Cross-Platform:** A single WebGL build works on any desktop browser that supports WebGL (Chrome, Firefox, Safari, Edge), regardless of the underlying OS.
    *   **Easy to Share:** Sharing a link is much simpler than sharing a file.
*   **Cons:**
    *   **Performance:** Performance is generally lower than a standalone build due to the overhead of running in a browser. There are also memory and file size limitations.
    *   **Requires Internet:** The game must be loaded from a web server each time it's played.
    *   **Loading Times:** Larger games can have significant initial loading times.

---

**In summary:** If you want someone to download your game and run it on their computer with the best performance, you create a **Standalone Build**. If you want to give someone a link so they can play your game instantly in their browser, you create a **WebGL Build**.
