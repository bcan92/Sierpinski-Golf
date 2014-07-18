namespace System.Linq{using _=String;class P{static void Main(_[]a){
int v=1<<a[0][0]-48,u=++v;var b=new bool[u];b[0]=1>0;
for(;v-->1;){Console.WriteLine(new _(' ',v)+_.Concat(b.Select(
n=>n?@"/\":"  ")));b=b.Select((n,k)=>k<=u-v&k>0?n^b[k-1]:n).ToArray();}}}}