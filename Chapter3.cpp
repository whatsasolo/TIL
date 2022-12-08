#include <opencv2/imgcodecs.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/imgproc.hpp>
#include <iostream>
#include <direct.h>

using namespace cv;
using namespace std;


/////////////   Basic Functions    ///////////////

void main() {
	string path = "Resources/test.png";

	// Mat is Matrix data type
	Mat img = imread(path);
	Mat imgResize;

	cout << img.size() << endl;

	//resize(img, imgResize, Size());

	imshow("Image", img);


	// 0 for infinity
	waitKey(0);
}
