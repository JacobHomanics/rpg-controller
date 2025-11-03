# RPG Controller

A complete, out-of-the-box RPG character controller package for Unity with basic movement, animations, and camera systems.

## Features

### Core Systems

- **Player Movement (`PlayerMotor`)**

  - Character controller-based movement
  - Configurable movement speeds (forward, backward, left, right)
  - Jump mechanics with customizable jump power
  - Mid-air movement control
  - Gravity system
  - Ground detection and events
  - Combo-based input system supporting keyboard and mouse inputs

- **Player Rotation (`PlayerRotator`)**

  - Configurable rotation speeds for left/right turning
  - Bidirectional input blocking option
  - Combo-based rotation controls

- **Player Animation (`PlayerAnimator`)**

  - Automatic animation parameter updates based on movement
  - Horizontal and vertical movement blending
  - Jump animation support (trigger or play-based)
  - IsMoving boolean parameter support
  - Configurable damping for smooth transitions

- **Input System**
  - Flexible combo-based input system
  - Supports multiple input types (KeyCode, MouseButton)
  - Multiple resolution types (Down, Up, Active)
  - Configurable via Scriptable Objects

### Camera Systems

- **Camera Bob**

  - Head bob effect for immersive movement feel
  - Configurable via Scriptable Objects

- **Cinemachine Integration**

  - Third-person follow camera with scroll wheel zoom
  - User and system settings for zoom controls
  - Requires Cinemachine 3.1.3

- **Offset Drag Camera**
  - Camera offset dragging system
  - User and system settings for camera controls
  - Smooth camera movement

### Additional Features

- **Cursor Management**

  - Custom cursor icon support
  - Easy switching between custom and default cursors

- **Scriptable Object Configuration**
  - All settings configurable via Scriptable Objects
  - Separate user and system settings where applicable
  - Easy to create presets and variants

## Requirements

- **Unity Version**: 6000.0 (31f1 or later)
- **Dependencies**:
  - `com.unity.cinemachine`: 3.1.3

## Installation

1. Add this package to your Unity project via Package Manager
2. Ensure Cinemachine is installed (version 3.1.3)
3. Import the package into your project

## Quick Start

### Setting Up a Player

1. **Create or use the provided Player prefab** (`Prefabs/Player.prefab`)
2. **Configure Scriptable Objects**:
   - Create or use existing Scriptable Objects from `Scriptable Objects/Player/Config/`
   - Create or use keybind configurations from `Scriptable Objects/Player/Controls/`
3. **Assign references**:
   - Assign `PlayerMotorScriptableObject` and `PlayerMotorKeybindsScriptableObject` to `PlayerMotor`
   - Assign `PlayerRotatorScriptableObject` and `PlayerRotatorKeybindsScriptableObject` to `PlayerRotator`
   - Assign `PlayerMotor` reference to `PlayerAnimator`
4. **Set up Animator**:
   - Assign your Animator component to `PlayerAnimator`
   - Ensure your Animator Controller has parameters: `X`, `Z`, `Jump`, and optionally `IsMoving`

### Setting Up a Camera

1. **Use the provided Camera Rig prefab** (`Prefabs/Camera Rig - Character.prefab`)
2. **Configure camera Scriptable Objects** from `Scriptable Objects/Camera/`
3. **Choose your camera system**:
   - **Bob**: For head bob effects
   - **Cinemachine**: For third-person camera with zoom
   - **Offset Drag**: For draggable camera offset

### Demo Scene

Check out the `Scenes/Demo/Demo.unity` scene for a complete example setup.

## Components Overview

### PlayerMotor

Handles all character movement logic including:

- Ground-based movement
- Jumping
- Gravity
- Mid-air movement
- Input processing via combos

**Events Available:**

- `Moved`: Fired every frame when movement occurs
- `MovingForward`, `MovingBackward`, `MovingLeft`, `MovingRight`: Directional movement events
- `Jumped`: Fired when player jumps
- `Grounded`: Fired when player lands on ground

### PlayerRotator

Handles character rotation:

- Left/right rotation based on input combos
- Configurable rotation speeds
- Bidirectional input blocking option

**Events Available:**

- `Turned`: Fired when rotation occurs
- `TurnedLeft`, `TurnedRight`: Directional rotation events

### PlayerAnimator

Automatically updates Animator parameters based on player movement:

- `X`: Horizontal movement (-1 to 1)
- `Z`: Vertical movement (-1 to 1)
- `Jump`: Jump trigger/state
- `IsMoving`: Boolean for movement state

### Combo System

The combo system allows for flexible input configuration:

- **KeyCode combos**: Multiple keyboard keys can be combined
- **Mouse button combos**: Mouse button combinations
- **Resolution types**:
  - `Down`: Key/button pressed this frame
  - `Up`: Key/button released this frame
  - `Active`: Key/button held down

## Scriptable Objects

All configuration is done via Scriptable Objects located in `Scriptable Objects/`:

### Player Configuration

- `PlayerMotorScriptableObject`: Movement speeds, jump power, gravity, etc.
- `PlayerMotorKeybindsScriptableObject`: Input keybinds for movement
- `PlayerRotatorScriptableObject`: Rotation speeds
- `PlayerRotatorKeybindsScriptableObject`: Input keybinds for rotation

### Camera Configuration

- **Bob**: `BobUserSettingsScriptableObject`
- **Cinemachine**: `ZoomUserSettingsScriptableObject`, `ZoomSystemSettingsScriptableObject`
- **Offset Drag**: `CameraOffsetDragUserSettingsScriptableObject`, `CameraOffsetDragSystemSettingsScriptableObject`

## Project Structure

```
RPG Controller/
├── Scripts/
│   ├── PlayerMotor.cs
│   ├── PlayerRotator.cs
│   ├── PlayerAnimator.cs
│   ├── Combo.cs
│   ├── Camera/
│   │   ├── Bob/
│   │   ├── Cinemachine/
│   │   └── Offset Drag/
│   └── Cursor/
├── Prefabs/
│   ├── Player.prefab
│   └── Camera Rig - Character.prefab
├── Scriptable Objects/
│   ├── Player/
│   └── Camera/
├── Scenes/
│   └── Demo/
└── Animations/
```

## Third Party Assets

This package includes third-party assets:

- **Human Basic Motions FREE** by Kevin Iglesias (animations)
- **Gauntlet Cursor** assets (cursor textures)

See `Third Party Notices.md` for more information.

## Author

**Jacob Homanics**

- Email: homanicsjake@gmail.com
- Website: jacobhomanics.com

## License

See `LICENSE.md` for license information.

## Version

Current version: 0.0.1

## Support

For issues, questions, or contributions, please refer to the project repository or contact the author.
