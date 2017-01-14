# Unity Shader tests
> Just testing Unity shader development

This is my personal repository for testing Unity's Cg / HLSL shader development.
Feel free to use any of the shaders and give feedback.

## Getting started

Just open the project folder in the most recent Unity and open a scene.

## Different shader demos

Currently there are the following shaders:

### n-bit pixelize screen shader

This shader creates a customizable pixelization effect and reduces the amount
of used colors to n bits (e.g. setting 8-bit colors this shader limits the
colors to approximately 256).

![8-bit 128 pixel preview](https://cloud.githubusercontent.com/assets/2676795/21956067/ce844696-da80-11e6-8985-683ed6363564.gif)

### n-line screen split shader

This shader splits the screen to n lines and transitions them to off the screen.

![10-line screen split preview](https://cloud.githubusercontent.com/assets/2676795/21956098/7e86c744-da81-11e6-881a-7392156e5f4b.gif)

## Licensing

The code in this project is licensed under MIT license.
