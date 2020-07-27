//生成XCODE工程里再加上一个框架，在General里的最下面的Linked Frameworks andLibraries项,下面有个+号，点了之后搜AdSupport.framework,添加进来
#import <AdSupport/ASIdentifierManager.h>

extern "C"{
    char * GetIphoneADID(){
        NSString * IDFA = [[[ASIdentifierManager sharedManager] advertisingIdentifier] UUIDString];
        BOOL isEmpty = [[IDFA stringByReplacingOccurrencesOfString:@"-" withString:@""] stringByReplacingOccurrencesOfString:@"0" withString:@""].length;
	    if (isEmpty) {
	    }else {
	        //为空，获取UUID作为唯一标识
	        IDFA = [[[UIDevice currentDevice] identifierForVendor] UUIDString];
	    }
        NSLog(@" === %@",IDFA);
        const char *a = [IDFA UTF8String];
        char * b = (char*)malloc(strlen(a)+1);
        strcpy(b, a);
        return b;
    }
}
