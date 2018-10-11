# DataPAL
ArcMap 10x add-in 
With a few changes this add-in can be used by any organization to give users the ability to quickly find and add layers to the active map. The backend crawls through a given directory and add all the layers of that folder to a dcit element with the layer name as a key and the layer path as the value. Our data library structure consists of a single geodatabase that contains all of the feature datasets and thier respective feature classes. Then each feature class has a corresponding layer saved into a folder based on category i.e. '\DataPAL\environmental', '\DataPAL\transportation', \DataPAL'boundaries'. Each folder is crawled and any file with the .lyr extension is added to the dictionary. Can be modified to use REST endpoints, shapefile, feature classes etc.
