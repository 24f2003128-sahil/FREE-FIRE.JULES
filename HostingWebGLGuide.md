# WebGL Hosting Guide: Sharing Your Web Game

Once you have your WebGL build folder, you need to upload it to a web hosting service to get a public link that you can share. You can't just send the folder to your friends, as it needs to be served by a proper web server to run correctly in a browser.

Here are a few excellent, free, and easy-to-use options for indie game developers.

## Option 1: Itch.io (Recommended for Beginners)

[Itch.io](https://itch.io) is an incredibly popular platform for indie game developers to host, share, and sell their games. Their process for uploading WebGL games is very straightforward.

### How it Works:

1.  **Create an Account:** Sign up for a free account on [itch.io](https://itch.io).
2.  **Create a New Project:** Go to your `Dashboard` and click the `Create new project` button.
3.  **Fill in Game Details:** Give your game a title, a short description, and upload a cover image if you have one.
4.  **Set "Kind of project":** Set this to `HTML`. This will tell itch.io that you're uploading a web-based game.
5.  **Upload the Game:**
    *   First, **zip** your entire WebGL build folder (the one containing the `index.html`, `Build`, and `TemplateData` folders).
    *   Click the `Upload files` button on the project page and select your `.zip` file.
    *   Once uploaded, check the box that says **"This file will be played in the browser"**.
6.  **Set Embed Options:** You can set the default size of your game window. It's a good idea to match this to the resolution you set in Unity's Player Settings.
7.  **Save and View:** Save your project page (you can keep it in "Draft" mode initially). You can then view the page and test your game directly in the browser. Once you're happy, you can make it public and share the link with everyone!

## Option 2: Unity Play

[Unity Play](https://play.unity.com/) is Unity's own platform for sharing WebGL games. It's designed to be simple and is well-integrated with the Unity ecosystem.

### How it Works:

1.  **Open the Unity Hub.**
2.  Go to the **"Publish"** tab and select **"Unity Play"**.
3.  Sign in with your Unity ID.
4.  The Hub will automatically find recent WebGL builds from your projects.
5.  Select the build you want to upload, give it a name and description, and publish it.
6.  Unity Play will provide you with a direct link to your game that you can share.

## Option 3: GitHub Pages

For those who are more technically inclined or already use Git and GitHub, you can host your WebGL game for free using [GitHub Pages](https://pages.github.com/).

### How it Works:

1.  **Create a GitHub Repository:** Create a new public repository on GitHub.
2.  **Upload Your Build:** Upload the contents of your WebGL build folder to the repository.
3.  **Enable GitHub Pages:**
    *   Go to your repository's `Settings` tab.
    *   Click on the `Pages` section.
    *   Under `Source`, select the branch you want to deploy from (usually `main`).
    *   Click `Save`.
4.  **Access Your Game:** After a few minutes, your game will be live at a URL like `https://<your-username>.github.io/<your-repository-name>/`.

---

For most users, **Itch.io is the best starting point**. It's built for games, has a great community, and makes the process of uploading and sharing extremely simple.
