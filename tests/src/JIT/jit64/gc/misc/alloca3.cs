// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

internal class Test
{
    private static int s_x = 25;

    public static unsafe int Main()
    {
        int* px = stackalloc int[s_x];

        String s1 = "<s1>";
        String s2 = "<s2>";
        String s3 = s1 + s2;
        String s4 = foo(s3);

        s4 = s1 + s2 + s3 + s4;

        return 100;
    }

    public static String foo(String s3)
    {
        return s3 + s3;
    }
}
