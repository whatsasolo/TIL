#include <opencv2/imgcodecs.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/imgproc.hpp>
#include <iostream>

using namespace cv;
using namespace std;


/////////////   Resize and Crop  ///////////////

void main() {
	string path = "Resources/test.png";

	// Mat is Matrix data type
	Mat img = imread(path);
	Mat imgResize, imgCrop;

	// cout << img.size() << endl;

	resize(img, imgResize, Size(), 0.5,0.5);

	Rect roi(100, 100, 300, 250);

	imgCrop = img(roi);

	imshow("Image", img);
	imshow("ImageResize", imgResize);
	imshow("ImageCrop", imgCrop);


	// 0 for infinity
	waitKey(0);
}
