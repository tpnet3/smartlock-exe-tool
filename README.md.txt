프로그램 실행을 위해 빌드된 smartlocker.exe 파일의 폴더에 SmartLockerTemplate 의 Directory Junction 폴더를 만드세요.

'''
MKLINK [[/D] | [/H] | [/J]] Link Target

        /D      Creates a directory symbolic link.  Default is a file
                symbolic link.
        /H      Creates a hard link instead of a symbolic link.
        /J      Creates a Directory Junction.
        Link    Specifies the new symbolic link name.
        Target  Specifies the path (relative or absolute) that the new link
                refers to.
'''

예제:

'''
mklink /J SmartLockerTemplate ..\..\..\SmartLockerTemplate
'''