# xUnityPicture
Unity Picture project.

### Scenes
#### **main.unity**  

  Fetcher.cs is attached to the Image gameObject, load cloud picture
  
#### **other.unity**  
  
  there is no Fetcher.cs attach to the gameObject Image, add it at Runtime, load smartisan logo

#### **canvasScene.unity**  
  
  there is only an empty Canvas in this scene, all the Image and Fetcher is added by the code in Runtime.

---
### > change log
  - 2017.3.7: add basic Fetcher.cs, using coroutine to request online pictures (case: for SLG UIAd requirement)
  - 2017.3.8: add canvasScene and add logic to add picture in an empty canvas by code
  - 2017.3.8: add button logic - open URL to cloud platform of Smartisan
