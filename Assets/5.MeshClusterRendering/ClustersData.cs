using UnityEngine;

namespace MeshClusterRendering
{
	public class ClustersData : ScriptableObject
	{
		public Mesh RawMesh;
		public string Name;
		public int QuadsPerCluster;
		public int Count;
		public Vector3[] Vertices;
		public Bounds[] BoundingBoxes;
	}
}