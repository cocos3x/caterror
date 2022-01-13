using UnityEngine;
internal enum GZipDecoder.GzipHeaderState
{
    // Fields
    ReadingID1 = 0
    ,ReadingID2 = 1
    ,ReadingCM = 2
    ,ReadingFLG = 3
    ,ReadingMMTime = 4
    ,ReadingXFL = 5
    ,ReadingOS = 6
    ,ReadingXLen1 = 7
    ,ReadingXLen2 = 8
    ,ReadingXLenData = 9
    ,ReadingFileName = 10
    ,ReadingComment = 11
    ,ReadingCRC16Part1 = 12
    ,ReadingCRC16Part2 = 13
    ,Done = 14
    ,ReadingCRC = 15
    ,ReadingFileSize = 16
    

}
