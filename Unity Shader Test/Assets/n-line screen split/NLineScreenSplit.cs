using System.Collections;
using UnityEngine;

[ExecuteInEditMode]
public class NLineScreenSplit : MonoBehaviour {

	[Range(0.0f, 1.0f)]
	public float move = 0;
	public int steps = 10;
	private Material material;

	// Creates a private material used to the effect
	void Awake () {
		material = new Material( Shader.Find("Test/NLineScreenSplit") );
	}

	// Postprocess the image
	void OnRenderImage (RenderTexture source, RenderTexture destination) {
		material.SetFloat("move", move);
		material.SetFloat("steppi", 1.0f / steps);
		Graphics.Blit (source, destination, material);
	}
}

