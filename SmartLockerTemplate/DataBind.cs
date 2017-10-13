using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLockerTemplate
{
    class DataBind
    {
        // exe 바이너리가 바운드 됩니다.
        public static readonly string BINARY/*@BINARY*/;

        // exe 해시값이 바운드 됩니다.
        public static readonly string EXE_HASH/*@EXE_HASH*/;

        // 원본 파일 이름이 바운드 됩니다.
        public static readonly string FILENAME/*@FILENAME*/;

        // .NET 여부가 바운드 됩니다. (0: .net 아님, 1: .net)
        public static readonly int IS_DOT_NET/*@IS_DOT_NET*/;

        // 공개키가 바운드 됩니다.
        public static readonly string PUBLIC_KEY/*@PUBLIC_KEY*/;
    }
}
