# YOLOcs
Tích hợp YOLOv7 vào WinForm C# sử dụng OpenCV

## Convert yolov7.pt to yolov7.onnx
1. Clone code from: https://github.com/WongKinYiu/yolov7/tree/u5
2. Using this command to convert:
```
export.py --weights yolov7.pt --include onnx --opset=16
```

## Convert Custom yolov7 model to onnx

1. Clone code from: https://github.com/WongKinYiu/yolov7/tree/u5 (done)
2. Copy file from yolov7/cfg/deploy/yolov7.yaml to yolov7-u5\cfg\deploy\yolov7_custom_weight.yaml (done)
3. Download file https://github.com/majnas/yolov7_opencv_cpp/blob/master/reparameterization_yolov7.py to yolov7-u5\reparameterization_yolov7.py (done)
4. Edit file reparameterization_yolov7.py, edit nc (num_class)
5. Copy best.pt to yolov7-u5\cfg\training\
6. Run file reparameterization_yolov7.py, result is yolov7-u5\cfg\deploy\custom_weight_reparameterized.pt
7. Export to onnx
```
python export.py --weights cfg/deploy/custom_weight_reparameterized.pt --topk-all 100 --iou-thres 0.65 --conf-thres 0.35 --img-size 224 224
```
8. Result is custom_weight_reparameterized.onnx


Reference: https://github.com/majnas/yolov7_opencv_cpp/tree/master