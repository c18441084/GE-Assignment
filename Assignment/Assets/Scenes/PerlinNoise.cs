using UnityEngine;

public class PerlinNoise : MonoBehaviour
{

    // I have replaced some variables throughout the code with this 'placeholder' variable.
    // You will need to replace the 'placeholder' throughout the code with the correct variable.

    public int terrain_depth = 10;
    public int terrain_width = 256;
    public int terrain_height = 256;
    public float terrain_scale = 10f;
    public float terrain_offset_x = 10f;
    public float terrain_offset_y = 10f;

    void Start()
    {
        GenerateOffset();
        Terrain terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
        flat();
    }

    void GenerateOffset()
    {
        // Can you set these float variables to a random value?
        terrain_offset_x = Random.Range(0f, 100f);
        terrain_offset_y = Random.Range(0f, 100f);
    }

    TerrainData GenerateTerrain(TerrainData data)
    {
        data.heightmapResolution = terrain_width + 1;
        data.size = new Vector3(terrain_width, terrain_depth, terrain_height);  // The Vector3 takes in 3 integer values, but which values and in what order?
        data.SetHeights(0, 0, GenerateHeights());
        return data;
    }

    float[,] GenerateHeights()
    {
        float[,] heights = new float[terrain_width, terrain_height];
        for (int x = 0; x < terrain_width; x++) // What variable swaps with the placeholder here?
        {
            for (int y = 0; y < terrain_width; y++) // What variable swaps with the placeholder here?
            {
                heights[x, y] = CalculateHeights(x, y);
            }
        }
        return heights;
    }

    float CalculateHeights(int x, int y){
        float xCoordinate = ((float)x / terrain_width) * terrain_scale + terrain_offset_x;
        float yCoordinate = ((float)y / terrain_height) * terrain_scale + terrain_offset_y;
        return Mathf.PerlinNoise(xCoordinate, yCoordinate);
    }

    //Make a flat part of the terrain
    void flat()
        {
            Terrain terrain = GetComponent<Terrain>();
            int Axis_x = terrain.terrainData.heightmapResolution;
            int Axis_z = terrain.terrainData.heightmapResolution;
            float[,] heights = terrain.terrainData.GetHeights(0, 0, Axis_x, Axis_z);

            for (int x = Axis_x / 2 - (terrain_height/2); x < Axis_x / 2 + (terrain_height/2); x++)
            {
                for (int z = Axis_z / 2 - 13; z < Axis_z / 2 + 13; z++)
                {
                    heights[x, z] = 0;
                }
            }
            terrain.terrainData.SetHeights(0, 0, heights);

        }

      /*  void OnTriggerEnter(Collider other)
        {
          if(other.gameObject.name == "Car")
          {
            source.Play(1);
          }
        }*/
}
