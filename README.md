# Unity Shader tests
> Just testing Unity shader development

This is my personal repository for testing Unity's Cg / HLSL shader development.
Feel free to use any of the shaders and give feedback.

## Getting started

Just open the project folder in the most recent Unity and open a scene.

### Resources

* Unity's "Gentle Introduction to Shaders"
  * [Part 1](https://unity3d.com/learn/tutorials/topics/graphics/gentle-introduction-shaders)
  * [Part 2](http://www.alanzucconi.com/2015/06/17/surface-shaders-in-unity3d/)
  * [Part 4](http://www.alanzucconi.com/2015/07/01/vertex-and-fragment-shaders-in-unity3d/)
  * [Part 5](http://www.alanzucconi.com/2015/07/08/screen-shaders-and-postprocessing-effects-in-unity3d/)
* [Cg reference manual](http://developer.download.nvidia.com/cg/Cg_3.1/Cg-3.1_April2012_ReferenceManual.pdf)
  * [Same as a website](http://http.developer.nvidia.com/Cg/abs.html)
* [UnityCG.cgnic](https://docs.unity3d.com/Manual/SL-BuiltinIncludes.html) library
  * [Source of the structs](https://en.wikibooks.org/wiki/Cg_Programming/Unity/Debugging_of_Shaders#Pre-Defined_Input_Structures)
* [Graphics.Blit](https://docs.unity3d.com/ScriptReference/Graphics.Blit.html)
* Some [reference code](http://wiki.unity3d.com/index.php/Shader_Code) from Unity's wiki
*

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
