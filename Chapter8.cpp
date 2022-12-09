#include <opencv2/imgcodecs.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/imgproc.hpp>
#include <opencv2/objdetect.hpp>
#include <iostream>
#include <filesystem>

using namespace cv;
using namespace std;



/////////////   Images    ///////////////

void main() {
	VideoCapture cap(0);
	CascadeClassifier faceCascade;
	Mat img;
	
	Mat frame;

	faceCascade.load(".\\Resources\\haarcascade_frontalface_default.xml");
	if (faceCascade.empty()) { cout << "XML file not loaded" << endl; }
	if (!cap.isOpened()) { cerr << "Could not open camera" << endl; }

	while (true) {
		
		bool frame_valid = true;
		cap >> frame;

		if (frame_valid)
		{
			Mat grayframe;
			cvtColor(frame, grayframe, COLOR_BGR2GRAY);
			equalizeHist(grayframe, grayframe);
			
			vector<Rect> faces;

			faceCascade.detectMultiScale(grayframe, faces, 1.1, 3);

			Mat img_mosaic;
			Mat frame_original;
			frame.copyTo(frame_original);

			for (int i = 0; i < faces.size(); i++) 
			{

				Point lb(faces[i].x + faces[i].width, faces[i].y + faces[i].height);

				Point tr(faces[i].x, faces[i].y);

				img_mosaic = frame(Rect(lb, tr));
				Mat img_temp;

				resize(img_mosaic, img_temp, Size(img_mosaic.rows / 8, img_mosaic.cols / 8));
				resize(img_temp, img_mosaic, Size(img_mosaic.rows, img_mosaic.cols));
				rectangle(frame, lb, tr, Scalar(100 * (i - 2), 255, 255 * i), 3, 4, 0);
				rectangle(frame_original, lb, tr, Scalar(100 * (i - 2), 255, 255 * i), 3, 4, 0);
			}
			imshow("mosaic", frame);
			imshow("webcam", frame_original);


		}
		

		if (waitKey(30) == 27) break;

		//cap.read(img);
		//imshow("Image", img);


		//for (int i = 0; i < faces.size(); i++)
		//{
		//	rectangle(img, faces[i].tl(), faces[i].br(), Scalar(255, 0, 255), 3);
		//}
		//
		//waitKey(2);

	}

	/*string path = "Resources/test.png";
	Mat img = imread(path);*/

	
	//system("echo %cd%");
	//system("pause");
	
	//imshow("Image", img);
	//waitKey(0);
}

//void main() {

//	string path = "Resources/test.png";
//	Mat img = imread(path);
//
//	CascadeClassifier faceCascade;
//	//system("echo %cd%");
//	//system("pause");
//	faceCascade.load(".\\Resources\\haarcascade_frontalface_default.xml");
//
//	if (faceCascade.empty()) { cout << "XML file not loaded" << endl; }
//
//	vector<Rect> faces;
//	faceCascade.detectMultiScale(img, faces, 1.1, 10);
//
//	for (int i = 0; i < faces.size(); i++)
//	{
//		rectangle(img, faces[i].tl(), faces[i].br(), Scalar(255, 0, 255), 3);
//	}
//
//	imshow("Image", img);
//	waitKey(0);
//}