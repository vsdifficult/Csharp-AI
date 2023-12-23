using Emgu.CV; 
using Emgu.CV.CvEnum; 
using Emgu.CV.Structure; 
using Emgu.CV.Cvb;
using System.Text.RegularExpressions;

using Emgu.CV.Structure;
using System.Drawing;

// using Emgu.CV.
// перехват видеопотока 
Capture capture = new Capture(); 

// Для создания объекта, который распознает наше лицо или глаза, мы будем использовать замечательный класс HaarCascade. 
// Классификатор (а именно каскад форсированных классификаторов, работающих с Хаара-подобными функциями) обучается с 
// несколькими сотнями образцов видов конкретного объекта (например, лицо или автомобиль), называет положительные примеры, 
// которые масштабируются в тот же размер (скажем, 20х20), и отрицательные примеры — произвольные изображения одного и 
// того же размера.

// То есть при создании экземпляра класса HaarCascade в его конструкторе мы указываем ссылку на xml файл, 
// который содержит нужные нам данные. 

// //for face
// HaarCascade faceCascade = new HaarCascade("haarcascade_frontalface_alt.xml");
// //for eye
// HaarCascade eyeCascade = new HaarCascade("haarcascade_eye.xml");

// internal class HaarCascade
// {MM
// } 
using Dostoevsky;  
using Dostoevsky.Models; 

class Programm 
{  
    public static void Main() { 
          // 
          string defaultpathforcascadehuman = "data/datasets/human/haarcascade_fullbody.xml"; 
          string defaultpathforimageshuman = ""; 
          Console.ForegroundColor = ConsoleColor.Magenta; 
          Console.Write("[~ Path ~] faceCascadePath: "); 

          var newpath = Convert
    }
    public void detectionss(string faceCascadePath, 
                            string imagePath) { 
         // string faceCascadePath = ""; // путь к каскаду  
          CascadeClassifier facecascade = new CascadeClassifier(faceCascadePath); 
          
          //string imagePath = ""; // путь к изображению 
          Image<Bgr, byte> image = new Image<Bgr, byte>(imagePath);  
            
          Image<Gray, byte> grayimage = new image.Convert<Gray, byte>(); 
          
          var faces = facecascade.DetectMultiScale(grayimage, 1.1, 3,  Size.Empty);  

          foreach (var face in faces) { 
            image.Draw(face, new Bgr(0,0,255), 2);  
            CvInvoke.Imshow("Face detect", image);  
            // CvInvoke.WaitKey(0); 
            // CvInvoke.DestroyAllWindows();

          } 



    } 
}