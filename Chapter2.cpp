#include <opencv2/imgcodecs.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/imgproc.hpp>
#include <iostream>
#include <direct.h>

using namespace cv;
using namespace std;


/////////////   Images    ///////////////

void main() {
	string path = "Resources/test.png";

	// Mat is Matrix data type
	Mat img = imread(path);
	Mat imgGray, imgBlur, imgCanny;

	cvtColor(img, imgGray, COLOR_BGR2GRAY);
	GaussianBlur(img, imgBlur, Size(3, 3), 3, 0);
	Canny(imgBlur, imgCanny, 75, 75);


	imshow("Image", img);
	imshow("Image Gray", imgGray);
	imshow("Image Blur", imgBlur);
	imshow("Image Canny", imgCanny);
	
	// 0 for infinity
	waitKey(0);
}
