#include <opencv2/imgcodecs.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/imgproc.hpp>
#include <iostream>

using namespace cv;
using namespace std;


/////////////   Images    ///////////////

//void main() {
//	string path = "Resources/test.png";
//
//	// Mat is Matrix data type
//	Mat img = imread(path);
//	imshow("Image", img);
//	// 0 for infinity
//	waitKey(0);
//}


/////////////   Video    ///////////////
//
//int main() {
//	
//	string path = "C:\\Users\\GLIM. 22_54\\Documents\\Visual Studio 2015\\Projects\\Project2\\Project2\\Resources";
//	VideoCapture cap(path);
//	Mat img;
//
//
//	if (!cap.isOpened())
//	{
//		printf("Can't open the video");
//		getchar();
//		return -1;
//		
//	}
//
//	
//	getchar();

/////////////////// WHY?????????? ////////////////////

	//while (true) {
	//	
	//	cap.read(img);
	//	imshow("Image", img);
	//	waitKey(1);
	// }

//}

///////////////////////        Webcam        /////////////////////////
void main() {

	char curDir[1000];
	_getcwd(curDir, 1000);

	printf("%s", curDir);

	// only one camera : 0
	VideoCapture cap(0);
	Mat img;

	while (true)
	{
		cap.read(img);
		imshow("Image", img);
		waitKey(1);
	}

}