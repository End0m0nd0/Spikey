# 🐦 Spikey

![Platform](https://img.shields.io/badge/Platform-Android-3DDC84?logo=android&logoColor=white)
![Unity](https://img.shields.io/badge/Made_with-Unity_2020.3-black?logo=unity)
![C#](https://img.shields.io/badge/Language-C%23-blue)
![Version](https://img.shields.io/badge/Version-0.5-orange)

**Spikey** is a fast-paced 2D arcade mobile game for Android, inspired by *Don't Touch the Spikes*. Tap to flap, bounce from wall to wall, dodge the spikes and collect coins to unlock new birds, backgrounds and power-up upgrades.

## 🎥 Gameplay Showcase

[![Spikey Gameplay](https://img.youtube.com/vi/TWOJ_LINK_DO_YOUTUBE/hqdefault.jpg)](https://www.youtube.com/watch?v=TWOJ_LINK_DO_YOUTUBE)<br>
*(Click the image above to watch the gameplay video on YouTube)*

## 📸 Screenshots

<!-- TODO: replace the placeholders with real screenshots, e.g. docs/screenshots/menu.png -->
| Main Menu | Gameplay |
| :---: | :---: |
| ![Main Menu](https://placehold.co/640x360?text=Main+Menu) | ![Gameplay](https://placehold.co/640x360?text=Gameplay) |
| **Power-Ups** | **Skins & Backgrounds** |
| ![Power-Ups](https://placehold.co/640x360?text=Power-Ups) | ![Skins](https://placehold.co/640x360?text=Skins+%26+Backgrounds) |

## 💡 About the Project

The bird flies on its own from one side of the screen to the other – your only job is to keep it in the air. Every time it hits a wall it turns around, you score a point and a new set of spikes slides out of the opposite wall. Touch a spike and it's game over.

The longer you survive, the harder it gets:
* The bird **speeds up** slightly with every wall bounce.
* The number of spikes on the wall **grows with your score** (from 1 up to 4 at once).

### ✨ Key Features & Mechanics:
* **One-tap gameplay:** Simple controls, hard to master.
* **Coins:** A coin appears on the map every few bounces. Collect them to spend in the shop.
* **Power-Ups:** Three temporary abilities that randomly spawn during a run (see below).
* **Upgrade System:** Spend coins to permanently level up your power-ups.
* **30 Bird Skins:** Each skin has separate sprites for flying up and falling down.
* **5 Backgrounds:** Animated parallax backgrounds to unlock and equip.
* **Second Chance:** After hitting a spike, a 3-second countdown lets you watch a rewarded ad to continue the run.
* **Shop:** Watch an ad for +10 coins or buy coin packs, *Double Coins* and *Max Power-Ups* (Unity IAP).
* **High Score & Save System:** Your best score, coins, unlocked items and upgrade levels are saved between sessions.
* **Options:** Separate volume sliders for music and sound effects.

## ⚡ Power-Ups

Only one power-up can be on the map (or active) at a time. Each time the bird bounces off a wall there is a chance that a new one spawns somewhere on the screen – fly through it to activate it.

| Power-Up | Effect |
| --- | --- |
| 🐣 **Smaller Bird** | Shrinks the bird, making it much easier to squeeze between spikes. |
| 🪶 **Lower Jump** | Reduces the jump force, so every tap is shorter and more precise. |
| 🛡️ **Shield** | Gives you a second life – hitting a spike with the shield on breaks the shield and bounces the bird back instead of ending the run. |

### ⬆️ Upgrades

In the **Power-Ups** menu you can spend coins to level up your abilities. Each upgrade costs *current level × 15* coins.

| Upgrade | What it improves | Level 1 → Max |
| --- | --- | --- |
| **Spawn Chance** | Chance that a power-up spawns on a wall bounce | ~15% → ~25% |
| **Duration Time** | How long every power-up lasts | 10 s → 20 s |
| **Smaller Bird** | How small the bird gets | 76% → 56% of normal size |
| **Lower Jump** | How much the jump force is reduced | −11% → −23% |

## 🛠️ Technologies & Tools

* **Game Engine:** Unity 2020.3.22f1 (LTS), 2D
* **Programming Language:** C#
* **Target Platform:** Android (min. API 22, target API 31), landscape
* **Monetization:** Unity Ads 3.7.5 (rewarded video), Unity IAP 4.0.3
* **UI:** Unity UI, TextMesh Pro
* **Visuals:** 2D Pixel Perfect, custom multi-layer parallax backgrounds

## 👤 Author

* **[Jędrzej Nowakowski (End0m0nd0)](https://github.com/End0m0nd0)** - Developer

## 🚀 How to Run the Project

### Requirements
* [Git](https://git-scm.com/downloads)
* [Unity Hub](https://unity.com/download)
* **Unity 2020.3.22f1 (LTS)** – the editor version this project was made with. Other 2020.3.x LTS versions should also work.
* **Android Build Support** module (only needed to build the APK).

### Steps
1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/End0m0nd0/Spikey.git
   ```
2. Open **Unity Hub**, go to **Projects → Add → Add project from disk** and select the cloned `Spikey` folder.
3. If Unity 2020.3.22f1 is not installed, Unity Hub will offer to install it – accept, or pick another 2020.3.x version you already have.
4. Open the project. The first launch can take a few minutes while Unity imports assets and generates the `Library` folder.
5. In the **Project** window open the scene `Assets/Scenes/Game_Menu.unity`.
6. In the **Game** view set a landscape aspect ratio (e.g. *16:9*).
7. Press **▶ Play** in the editor to start the game from the main menu.

> In the editor, ads run in test mode and in-app purchases use Unity's fake store, so you can test them without spending real money.

### Building for Android
1. Go to **File → Build Settings…**, select **Android** and click **Switch Platform**.
2. Make sure `Game_Menu` is the first scene in the *Scenes In Build* list (followed by `Game_Scene`).
3. The release keystore is **not** included in the repository. For a test build go to **Player Settings → Publishing Settings** and uncheck **Custom Keystore** (Unity will use the debug keystore).
4. Click **Build** (or **Build And Run** with a phone connected via USB).

## 🎮 Controls

| Action | Android | Editor / PC |
| --- | --- | --- |
| Flap (jump) | `Tap` the screen | `Left Mouse Button` |
| Pause / Resume | `Back` button | `Esc` |

After resuming, the game waits for a 3-second countdown before the bird starts moving again.
