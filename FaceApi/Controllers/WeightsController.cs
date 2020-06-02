using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace TestFaceApi.Controllers
{
    [Route("weights")]
    public class WeightsController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public WeightsController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("age_gender_model-shard1")]
        public IActionResult AgeModel()
        {
            return Content(System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "weights", "age_gender_model-shard1")), "text/plain");
        }

        [HttpGet("face_expression_model-shard1")]
        public IActionResult FaceExpressionModel()
        {
            return Content(System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "weights", "face_expression_model-shard1")), "text/plain");
        }

        [HttpGet("face_landmark_68_model-shard1")]
        public IActionResult FaceLandmark68Model()
        {
            return Content(System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "weights", "face_landmark_68_model-shard1")), "text/plain");
        }

        [HttpGet("face_landmark_68_tiny_model-shard1")]
        public IActionResult FaceLandmark68TinyModel()
        {
            return Content(System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "weights", "face_landmark_68_tiny_model-shard1")), "text/plain");
        }

        [HttpGet("face_recognition_model-shard1")]
        public IActionResult FaceLRecognitionModelS1()
        {
            return Content(System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "weights", "face_recognition_model-shard1")), "text/plain");
        }

        [HttpGet("face_recognition_model-shard2")]
        public IActionResult FaceLRecognitionModelS2()
        {
            return Content(System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "weights", "face_recognition_model-shard2")), "text/plain");
        }

        [HttpGet("mtcnn_model-shard1")]
        public IActionResult MtcnnModel()
        {
            return Content(System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "weights", "mtcnn_model-shard1")), "text/plain");
        }

        [HttpGet("ssd_mobilenetv1_model-shard1")]
        public IActionResult MobileNetV1ModelS1()
        {
            return Content(System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "weights", "ssd_mobilenetv1_model-shard1")), "text/plain");
        }

        [HttpGet("ssd_mobilenetv1_model-shard2")]
        public IActionResult MobileNetV1ModelS2()
        {
            return Content(System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "weights", "ssd_mobilenetv1_model-shard2")), "text/plain");
        }

        [HttpGet("tiny_face_detector_model-shard1")]
        public IActionResult TinyFaceDetectorModel()
        {
            return Content(System.IO.File.ReadAllText(Path.Combine(_hostingEnvironment.WebRootPath, "weights", "tiny_face_detector_model-shard1")), "text/plain");
        }
    }
}