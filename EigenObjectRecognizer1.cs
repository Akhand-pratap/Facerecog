using System;
using System.Diagnostics;
using Emgu.CV.Structure;

namespace Emgu.CV
{
   /// <summary>
   /// An object recognizer using PCA (Principle Components Analysis)
   /// </summary>
   [Serializable]
   public class EigenObjectRecognizer
   {
      private Image<Gray, Single>[] _eigenImages;
      private Image<Gray, Single> _avgImage;
      private Matrix<float>[] _eigenValues;
      private string[] _labels;
      private double _eigenDistanceThreshold;

      /// <summary>
      /// Get the eigen vectors that form the eigen space
      /// </summary>
      /// <remarks>The set method is primary used for deserialization, do not attemps to set it unless you know what you are doing</remarks>
      public Image<Gray, Single>[] EigenImages
      {
         get { return _eigenImages; }
         set { _eigenImages = value; }
      }

      /// <summary>
      /// Get or set the labels for the corresponding training image
      /// </summary>
      public String[] Labels
      {
         get { return _labels; }
         set { _labels = value; }
      }

      /// <summary>
      /// Get or set the eigen distance threshold.
      /// The smaller the number, the more likely an examined image will be treated as unrecognized object. 
      /// Set it to a huge number (e.g. 5000) and the recognizer will always treated the examined image as one of the known object. 
      /// </summary>
      public double EigenDistanceThreshold
      {
         get { return _eigenDistanceThreshold; }
         set { _eigenDistanceThreshold = value; }
      }

      /// <summary>
      /// Get the average Image. 
      /// </summary>
      /// <remarks>The set method is primary used for deserialization, do not attemps to set it unless you know what you are doing</remarks>
      public Image<Gray, Single> AverageImage
      {
         get { return _avgImage; }
         set { _avgImage = value; }
      }

      /// <summary>
      /// Get the eigen values of each of the training image
      /// </summary>
      /// <remarks>The set method is primary used for deserialization, do not attemps to set it unless you know what you are doing</remarks>
      public Matrix<float>[] EigenValues
      {
         get { return _eigenValues; }
         set { _eigenValues = value; }
      }

      private EigenObjectRecognizer()
      
   }
}
