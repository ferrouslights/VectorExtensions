using UnityEngine;

namespace ferrouslights.VectorExtensions
{
    /// <summary>
    /// This class defines a rather large group of extension methods for mixmatching vector2, vector3 and vector4's xyzw/rgba properties
    /// </summary>
    public static class VectorExtensions
    {
        #region Vector to float extensions
        public static float r(this Vector2 v) => v.x;
        public static float r(this Vector3 v) => v.x;
        public static float r(this Vector4 v) => v.x;
        
        public static float g(this Vector2 v) => v.y;
        public static float g(this Vector3 v) => v.y;
        public static float g(this Vector4 v) => v.y;
        
        public static float b(this Vector3 v) => v.z;
        public static float b(this Vector4 v) => v.z;
        
        public static float a(this Vector4 v) => v.w;

        #endregion
        
        #region Vector2 extensions
            public static Vector2 xy(this Vector2 v) => new Vector2(v.x, v.y);
            public static Vector2 yx(this Vector2 v) => new Vector2(v.y, v.x);
            public static Vector2 xx(this Vector2 v) => new Vector2(v.x, v.x);
            public static Vector2 yy(this Vector2 v) => new Vector2(v.y, v.y);
        #endregion
        
        #region Vector3 to Vector2 extensions
            // starting with x
            public static Vector2 xy(this Vector3 v) => new Vector2(v.x, v.y);
            public static Vector2 rg(this Vector3 v) => new Vector2(v.x, v.y);
            
            public static Vector2 xx(this Vector3 v) => new Vector2(v.x, v.x);
            public static Vector2 rr(this Vector3 v) => new Vector2(v.x, v.x);
            
            public static Vector2 xz(this Vector3 v) => new Vector2(v.x, v.z);
            public static Vector2 rb(this Vector3 v) => new Vector2(v.x, v.z);
            
            // starting with y
            public static Vector2 yx(this Vector3 v) => new Vector2(v.y, v.x);
            public static Vector2 gr(this Vector3 v) => new Vector2(v.y, v.x);
            
            public static Vector2 yy(this Vector3 v) => new Vector2(v.y, v.y);
            public static Vector2 gg(this Vector3 v) => new Vector2(v.y, v.y);
            
            public static Vector2 yz(this Vector3 v) => new Vector2(v.y, v.z);
            public static Vector2 gb(this Vector3 v) => new Vector2(v.y, v.z);
            
            // starting with z
            public static Vector2 zx(this Vector3 v) => new Vector2(v.z, v.x);
            public static Vector2 br(this Vector3 v) => new Vector2(v.z, v.x);
            
            public static Vector2 zz(this Vector3 v) => new Vector2(v.z, v.z);
            public static Vector2 bb(this Vector3 v) => new Vector2(v.z, v.z);
            
            public static Vector2 zy(this Vector3 v) => new Vector2(v.z, v.y);
            public static Vector2 bg(this Vector3 v) => new Vector2(v.z, v.y);
        #endregion
        
        #region Vector3 to Vector3 extensions
            // starting with x 
            public static Vector3 xyz(this Vector3 v) => new Vector3(v.x, v.y, v.z);
            public static Vector3 rgb(this Vector3 v) => new Vector3(v.x, v.y, v.z);
            
            public static Vector3 xzy(this Vector3 v) => new Vector3(v.x, v.z, v.y);
            public static Vector3 rbg(this Vector3 v) => new Vector3(v.x, v.z, v.y);
            
            public static Vector3 xxx(this Vector3 v) => new Vector3(v.x, v.x, v.x);
            public static Vector3 rrr(this Vector4 v) => new Vector3(v.x, v.x, v.x);
            
            public static Vector3 xxy(this Vector3 v) => new Vector3(v.x, v.x, v.y);
            public static Vector3 rrg(this Vector3 v) => new Vector3(v.x, v.x, v.y);
            
            public static Vector3 xxz(this Vector3 v) => new Vector3(v.x, v.x, v.z);
            public static Vector3 rrb(this Vector3 v) => new Vector3(v.x, v.x, v.z);
            
            public static Vector3 xyx(this Vector3 v) => new Vector3(v.x, v.y, v.x);
            public static Vector3 rgr(this Vector3 v) => new Vector3(v.x, v.y, v.x);
            
            public static Vector3 xzx(this Vector3 v) => new Vector3(v.x, v.z, v.x);
            public static Vector3 rbr(this Vector3 v) => new Vector3(v.x, v.z, v.x);
            
            public static Vector3 xyy(this Vector3 v) => new Vector3(v.x, v.y, v.y);
            public static Vector3 rgg(this Vector3 v) => new Vector3(v.x, v.y, v.y);
            
            public static Vector3 xzz(this Vector3 v) => new Vector3(v.x, v.z, v.z);
            public static Vector3 rbb(this Vector3 v) => new Vector3(v.x, v.z, v.z);

            // starting with y
            public static Vector3 yxz(this Vector3 v) => new Vector3(v.y, v.x, v.z);
            public static Vector3 grb(this Vector3 v) => new Vector3(v.y, v.x, v.z);
            
            public static Vector3 yzx(this Vector3 v) => new Vector3(v.y, v.z, v.x);
            public static Vector3 gbr(this Vector3 v) => new Vector3(v.y, v.z, v.x);
            
            public static Vector3 yyy(this Vector3 v) => new Vector3(v.y, v.y, v.y);
            public static Vector3 ggg(this Vector3 v) => new Vector3(v.y, v.y, v.y);
            
            public static Vector3 yyx(this Vector3 v) => new Vector3(v.y, v.y, v.x);
            public static Vector3 ggr(this Vector3 v) => new Vector3(v.y, v.y, v.x);
            
            public static Vector3 yyz(this Vector3 v) => new Vector3(v.y, v.y, v.z);
            public static Vector3 ggb(this Vector3 v) => new Vector3(v.y, v.y, v.z);
            
            public static Vector3 yxy(this Vector3 v) => new Vector3(v.y, v.x, v.y);
            public static Vector3 grg(this Vector3 v) => new Vector3(v.y, v.x, v.y);
            
            public static Vector3 yxx(this Vector3 v) => new Vector3(v.y, v.x, v.x);
            public static Vector3 grr(this Vector3 v) => new Vector3(v.y, v.x, v.x);
            
            public static Vector3 yzz(this Vector3 v) => new Vector3(v.y, v.z, v.z);
            public static Vector3 gbb(this Vector3 v) => new Vector3(v.y, v.z, v.z);
            
            public static Vector3 yzy(this Vector3 v) => new Vector3(v.y, v.z, v.y);
            public static Vector3 gbg(this Vector3 v) => new Vector3(v.y, v.z, v.y);

            // starting with z
            public static Vector3 zxy(this Vector3 v) => new Vector3(v.z, v.x, v.y);
            public static Vector3 brg(this Vector3 v) => new Vector3(v.z, v.x, v.y);
            
            public static Vector3 zyx(this Vector3 v) => new Vector3(v.z, v.y, v.x);
            public static Vector3 bgr(this Vector3 v) => new Vector3(v.z, v.y, v.x);
            
            public static Vector3 zzz(this Vector3 v) => new Vector3(v.z, v.z, v.z);
            public static Vector3 bbb(this Vector3 v) => new Vector3(v.z, v.z, v.z);
            
            public static Vector3 zzx(this Vector3 v) => new Vector3(v.z, v.z, v.x);
            public static Vector3 bbr(this Vector3 v) => new Vector3(v.z, v.z, v.x);
            
            public static Vector3 zzy(this Vector3 v) => new Vector3(v.z, v.z, v.y);
            public static Vector3 bbg(this Vector3 v) => new Vector3(v.z, v.z, v.y);
            
            public static Vector3 zxx(this Vector3 v) => new Vector3(v.z, v.x, v.x);
            public static Vector3 brr(this Vector3 v) => new Vector3(v.z, v.x, v.x);
            
            public static Vector3 zyy(this Vector3 v) => new Vector3(v.z, v.y, v.y);
            public static Vector3 bgg(this Vector3 v) => new Vector3(v.z, v.y, v.y);
            
            public static Vector3 zyz(this Vector3 v) => new Vector3(v.z, v.y, v.z);
            public static Vector3 bgb(this Vector3 v) => new Vector3(v.z, v.y, v.z);
            
            public static Vector3 zxz(this Vector3 v) => new Vector3(v.z, v.x, v.z);
            public static Vector3 brb(this Vector3 v) => new Vector3(v.z, v.x, v.z);
            
            #endregion
            
        #region Vector4 extensions
            // all combinations of xyzw
            public static Vector4 xxxx(this Vector4 v) => new Vector4(v.x, v.x, v.x, v.x);
            public static Vector4 rrrr(this Vector4 v) => new Vector4(v.x, v.x, v.x, v.x);
            
            public static Vector4 xxxy(this Vector4 v) => new Vector4(v.x, v.x, v.x, v.y);
            public static Vector4 rrrg(this Vector4 v) => new Vector4(v.x, v.x, v.x, v.y);
            
            public static Vector4 xxxz(this Vector4 v) => new Vector4(v.x, v.x, v.x, v.z);
            public static Vector4 rrrb(this Vector4 v) => new Vector4(v.x, v.x, v.x, v.z);
            
            public static Vector4 xxxw(this Vector4 v) => new Vector4(v.x, v.x, v.x, v.w);
            public static Vector4 rrra(this Vector4 v) => new Vector4(v.x, v.x, v.x, v.w);
            
            public static Vector4 xxyx(this Vector4 v) => new Vector4(v.x, v.x, v.y, v.x);
            public static Vector4 rrgr(this Vector4 v) => new Vector4(v.x, v.x, v.y, v.x);
            
            public static Vector4 xxyy(this Vector4 v) => new Vector4(v.x, v.x, v.y, v.y);
            public static Vector4 rrgg(this Vector4 v) => new Vector4(v.x, v.x, v.y, v.y);
            
            public static Vector4 xxyz(this Vector4 v) => new Vector4(v.x, v.x, v.y, v.z);
            public static Vector4 rrgb(this Vector4 v) => new Vector4(v.x, v.x, v.y, v.z);
            
            public static Vector4 xxyw(this Vector4 v) => new Vector4(v.x, v.x, v.y, v.w);
            public static Vector4 rrga(this Vector4 v) => new Vector4(v.x, v.x, v.y, v.w);
            
            public static Vector4 xxzx(this Vector4 v) => new Vector4(v.x, v.x, v.z, v.x);
            public static Vector4 rrbr(this Vector4 v) => new Vector4(v.x, v.x, v.z, v.x);
            
            public static Vector4 xxzy(this Vector4 v) => new Vector4(v.x, v.x, v.z, v.y);
            public static Vector4 rrbg(this Vector4 v) => new Vector4(v.x, v.x, v.z, v.y);
            
            public static Vector4 xxzz(this Vector4 v) => new Vector4(v.x, v.x, v.z, v.z);
            public static Vector4 rrbb(this Vector4 v) => new Vector4(v.x, v.x, v.z, v.z);
            
            public static Vector4 xxzw(this Vector4 v) => new Vector4(v.x, v.x, v.z, v.w);
            public static Vector4 rrba(this Vector4 v) => new Vector4(v.x, v.x, v.z, v.w);
            
            public static Vector4 xxwx(this Vector4 v) => new Vector4(v.x, v.x, v.w, v.x);
            public static Vector4 rrar(this Vector4 v) => new Vector4(v.x, v.x, v.w, v.x);
            
            public static Vector4 xxwy(this Vector4 v) => new Vector4(v.x, v.x, v.w, v.y);
            public static Vector4 rrag(this Vector4 v) => new Vector4(v.x, v.x, v.w, v.y);
            
            public static Vector4 xxwz(this Vector4 v) => new Vector4(v.x, v.x, v.w, v.z);
            public static Vector4 rrab(this Vector4 v) => new Vector4(v.x, v.x, v.w, v.z);
            
            public static Vector4 xxww(this Vector4 v) => new Vector4(v.x, v.x, v.w, v.w);
            public static Vector4 rraa(this Vector4 v) => new Vector4(v.x, v.x, v.w, v.w);
            
            public static Vector4 xyxx(this Vector4 v) => new Vector4(v.x, v.y, v.x, v.x);
            public static Vector4 rgrr(this Vector4 v) => new Vector4(v.x, v.y, v.x, v.x);
            
            public static Vector4 xyxy(this Vector4 v) => new Vector4(v.x, v.y, v.x, v.y);
            public static Vector4 rgrg(this Vector4 v) => new Vector4(v.x, v.y, v.x, v.y);
            
            public static Vector4 xyxz(this Vector4 v) => new Vector4(v.x, v.y, v.x, v.z);
            public static Vector4 rgrb(this Vector4 v) => new Vector4(v.x, v.y, v.x, v.z);
            
            public static Vector4 xyxw(this Vector4 v) => new Vector4(v.x, v.y, v.x, v.w);
            public static Vector4 rgra(this Vector4 v) => new Vector4(v.x, v.y, v.x, v.w);
            
            public static Vector4 xyyx(this Vector4 v) => new Vector4(v.x, v.y, v.y, v.x);
            public static Vector4 rggr(this Vector4 v) => new Vector4(v.x, v.y, v.y, v.x);
            
            public static Vector4 xyyy(this Vector4 v) => new Vector4(v.x, v.y, v.y, v.y);
            public static Vector4 rggg(this Vector4 v) => new Vector4(v.x, v.y, v.y, v.y);
            
            public static Vector4 xyyz(this Vector4 v) => new Vector4(v.x, v.y, v.y, v.z);
            public static Vector4 rggb(this Vector4 v) => new Vector4(v.x, v.y, v.y, v.z);
            
            public static Vector4 xyyw(this Vector4 v) => new Vector4(v.x, v.y, v.y, v.w);
            public static Vector4 rgga(this Vector4 v) => new Vector4(v.x, v.y, v.y, v.w);
            
            public static Vector4 xyzx(this Vector4 v) => new Vector4(v.x, v.y, v.z, v.x);
            public static Vector4 rgbr(this Vector4 v) => new Vector4(v.x, v.y, v.z, v.x);
            
            public static Vector4 xyzy(this Vector4 v) => new Vector4(v.x, v.y, v.z, v.y);
            public static Vector4 rgbg(this Vector4 v) => new Vector4(v.x, v.y, v.z, v.y);
            
            public static Vector4 xyzz(this Vector4 v) => new Vector4(v.x, v.y, v.z, v.z);
            public static Vector4 rgbb(this Vector4 v) => new Vector4(v.x, v.y, v.z, v.z);
            
            public static Vector4 xyzw(this Vector4 v) => new Vector4(v.x, v.y, v.z, v.w);
            public static Vector4 rgba(this Vector4 v) => new Vector4(v.x, v.y, v.z, v.w);
            
            public static Vector4 xywx(this Vector4 v) => new Vector4(v.x, v.y, v.w, v.x);
            public static Vector4 rgar(this Vector4 v) => new Vector4(v.x, v.y, v.w, v.x);
            
            public static Vector4 xywy(this Vector4 v) => new Vector4(v.x, v.y, v.w, v.y);
            public static Vector4 rgag(this Vector4 v) => new Vector4(v.x, v.y, v.w, v.y);
            
            public static Vector4 xywz(this Vector4 v) => new Vector4(v.x, v.y, v.w, v.z);
            public static Vector4 rgab(this Vector4 v) => new Vector4(v.x, v.y, v.w, v.z);
            
            public static Vector4 xyww(this Vector4 v) => new Vector4(v.x, v.y, v.w, v.w);
            public static Vector4 rgaa(this Vector4 v) => new Vector4(v.x, v.y, v.w, v.w);
            
            public static Vector4 xzxx(this Vector4 v) => new Vector4(v.x, v.z, v.x, v.x);
            public static Vector4 rbrr(this Vector4 v) => new Vector4(v.x, v.z, v.x, v.x);
            
            public static Vector4 xzxy(this Vector4 v) => new Vector4(v.x, v.z, v.x, v.y);
            public static Vector4 rbrg(this Vector4 v) => new Vector4(v.x, v.z, v.x, v.y);
            
            public static Vector4 xzxz(this Vector4 v) => new Vector4(v.x, v.z, v.x, v.z);
            public static Vector4 rbrb(this Vector4 v) => new Vector4(v.x, v.z, v.x, v.z);
            
            public static Vector4 xzxw(this Vector4 v) => new Vector4(v.x, v.z, v.x, v.w);
            public static Vector4 rbra(this Vector4 v) => new Vector4(v.x, v.z, v.x, v.w);
            
            public static Vector4 xzyx(this Vector4 v) => new Vector4(v.x, v.z, v.y, v.x);
            public static Vector4 rbgr(this Vector4 v) => new Vector4(v.x, v.z, v.y, v.x);
            
            public static Vector4 xzyy(this Vector4 v) => new Vector4(v.x, v.z, v.y, v.y);
            public static Vector4 rbgg(this Vector4 v) => new Vector4(v.x, v.z, v.y, v.y);
            
            public static Vector4 xzyz(this Vector4 v) => new Vector4(v.x, v.z, v.y, v.z);
            public static Vector4 rbgb(this Vector4 v) => new Vector4(v.x, v.z, v.y, v.z);
            
            public static Vector4 xzyw(this Vector4 v) => new Vector4(v.x, v.z, v.y, v.w);
            public static Vector4 rbga(this Vector4 v) => new Vector4(v.x, v.z, v.y, v.w);
            
            public static Vector4 xzzx(this Vector4 v) => new Vector4(v.x, v.z, v.z, v.x);
            public static Vector4 rbbr(this Vector4 v) => new Vector4(v.x, v.z, v.z, v.x);
            
            public static Vector4 xzzy(this Vector4 v) => new Vector4(v.x, v.z, v.z, v.y);
            public static Vector4 rbbg(this Vector4 v) => new Vector4(v.x, v.z, v.z, v.y);
            
            public static Vector4 xzzz(this Vector4 v) => new Vector4(v.x, v.z, v.z, v.z);
            public static Vector4 rbbb(this Vector4 v) => new Vector4(v.x, v.z, v.z, v.z);
            
            public static Vector4 xzzw(this Vector4 v) => new Vector4(v.x, v.z, v.z, v.w);
            public static Vector4 rbba(this Vector4 v) => new Vector4(v.x, v.z, v.z, v.w);
            
            public static Vector4 xzwx(this Vector4 v) => new Vector4(v.x, v.z, v.w, v.x);
            public static Vector4 rbar(this Vector4 v) => new Vector4(v.x, v.z, v.w, v.x);
            
            public static Vector4 xzwy(this Vector4 v) => new Vector4(v.x, v.z, v.w, v.y);
            public static Vector4 rbag(this Vector4 v) => new Vector4(v.x, v.z, v.w, v.y);
            
            public static Vector4 xzwz(this Vector4 v) => new Vector4(v.x, v.z, v.w, v.z);
            public static Vector4 rbab(this Vector4 v) => new Vector4(v.x, v.z, v.w, v.z);
            
            public static Vector4 xzww(this Vector4 v) => new Vector4(v.x, v.z, v.w, v.w);
            public static Vector4 rbaa(this Vector4 v) => new Vector4(v.x, v.z, v.w, v.w);
            
            public static Vector4 xwxx(this Vector4 v) => new Vector4(v.x, v.w, v.x, v.x);
            public static Vector4 rarr(this Vector4 v) => new Vector4(v.x, v.w, v.x, v.x);
            
            public static Vector4 xwxy(this Vector4 v) => new Vector4(v.x, v.w, v.x, v.y);
            public static Vector4 rarg(this Vector4 v) => new Vector4(v.x, v.w, v.x, v.y);
            
            public static Vector4 xwxz(this Vector4 v) => new Vector4(v.x, v.w, v.x, v.z);
            public static Vector4 rarb(this Vector4 v) => new Vector4(v.x, v.w, v.x, v.z);
            
            public static Vector4 xwxw(this Vector4 v) => new Vector4(v.x, v.w, v.x, v.w);
            public static Vector4 rara(this Vector4 v) => new Vector4(v.x, v.w, v.x, v.w);
            
            public static Vector4 xwyx(this Vector4 v) => new Vector4(v.x, v.w, v.y, v.x);
            public static Vector4 ragr(this Vector4 v) => new Vector4(v.x, v.w, v.y, v.x);
            
            public static Vector4 xwyy(this Vector4 v) => new Vector4(v.x, v.w, v.y, v.y);
            public static Vector4 ragg(this Vector4 v) => new Vector4(v.x, v.w, v.y, v.y);
            
            public static Vector4 xwyz(this Vector4 v) => new Vector4(v.x, v.w, v.y, v.z);
            public static Vector4 ragb(this Vector4 v) => new Vector4(v.x, v.w, v.y, v.z);
            
            public static Vector4 xwyw(this Vector4 v) => new Vector4(v.x, v.w, v.y, v.w);
            public static Vector4 raga(this Vector4 v) => new Vector4(v.x, v.w, v.y, v.w);
            
            public static Vector4 xwzx(this Vector4 v) => new Vector4(v.x, v.w, v.z, v.x);
            public static Vector4 rabr(this Vector4 v) => new Vector4(v.x, v.w, v.z, v.x);
            
            public static Vector4 xwzy(this Vector4 v) => new Vector4(v.x, v.w, v.z, v.y);
            public static Vector4 rabg(this Vector4 v) => new Vector4(v.x, v.w, v.z, v.y);
            
            public static Vector4 xwzz(this Vector4 v) => new Vector4(v.x, v.w, v.z, v.z);
            public static Vector4 rabb(this Vector4 v) => new Vector4(v.x, v.w, v.z, v.z);
            
            public static Vector4 xwzw(this Vector4 v) => new Vector4(v.x, v.w, v.z, v.w);
            public static Vector4 raba(this Vector4 v) => new Vector4(v.x, v.w, v.z, v.w);
            
            public static Vector4 xwwx(this Vector4 v) => new Vector4(v.x, v.w, v.w, v.x);
            public static Vector4 raar(this Vector4 v) => new Vector4(v.x, v.w, v.w, v.x);
            
            public static Vector4 xwwy(this Vector4 v) => new Vector4(v.x, v.w, v.w, v.y);
            public static Vector4 raag(this Vector4 v) => new Vector4(v.x, v.w, v.w, v.y);
            
            public static Vector4 xwwz(this Vector4 v) => new Vector4(v.x, v.w, v.w, v.z);
            public static Vector4 raab(this Vector4 v) => new Vector4(v.x, v.w, v.w, v.z);
            
            public static Vector4 xwww(this Vector4 v) => new Vector4(v.x, v.w, v.w, v.w);
            public static Vector4 raaa(this Vector4 v) => new Vector4(v.x, v.w, v.w, v.w);
            
            // -----
            
            public static Vector4 yxxx(this Vector4 v) => new Vector4(v.y, v.x, v.x, v.x);
            public static Vector4 grrr(this Vector4 v) => new Vector4(v.y, v.x, v.x, v.x);
            
            public static Vector4 yxxy(this Vector4 v) => new Vector4(v.y, v.x, v.x, v.y);
            public static Vector4 grrg(this Vector4 v) => new Vector4(v.y, v.x, v.x, v.y);
            
            public static Vector4 yxxz(this Vector4 v) => new Vector4(v.y, v.x, v.x, v.z);
            public static Vector4 grrb(this Vector4 v) => new Vector4(v.y, v.x, v.x, v.z);
            
            public static Vector4 yxxw(this Vector4 v) => new Vector4(v.y, v.x, v.x, v.w);
            public static Vector4 grra(this Vector4 v) => new Vector4(v.y, v.x, v.x, v.w);
            
            public static Vector4 yxyx(this Vector4 v) => new Vector4(v.y, v.x, v.y, v.x);
            public static Vector4 grgr(this Vector4 v) => new Vector4(v.y, v.x, v.y, v.x);
            
            public static Vector4 yxyy(this Vector4 v) => new Vector4(v.y, v.x, v.y, v.y);
            public static Vector4 grgg(this Vector4 v) => new Vector4(v.y, v.x, v.y, v.y);
            
            public static Vector4 yxyz(this Vector4 v) => new Vector4(v.y, v.x, v.y, v.z);
            public static Vector4 grgb(this Vector4 v) => new Vector4(v.y, v.x, v.y, v.z);
            
            public static Vector4 yxyw(this Vector4 v) => new Vector4(v.y, v.x, v.y, v.w);
            public static Vector4 grga(this Vector4 v) => new Vector4(v.y, v.x, v.y, v.w);
            
            public static Vector4 yxzx(this Vector4 v) => new Vector4(v.y, v.x, v.z, v.x);
            public static Vector4 grbr(this Vector4 v) => new Vector4(v.y, v.x, v.z, v.x);
            
            public static Vector4 yxzy(this Vector4 v) => new Vector4(v.y, v.x, v.z, v.y);
            public static Vector4 grbg(this Vector4 v) => new Vector4(v.y, v.x, v.z, v.y);
            
            public static Vector4 yxzz(this Vector4 v) => new Vector4(v.y, v.x, v.z, v.z);
            public static Vector4 grbb(this Vector4 v) => new Vector4(v.y, v.x, v.z, v.z);
            
            public static Vector4 yxzw(this Vector4 v) => new Vector4(v.y, v.x, v.z, v.w);
            public static Vector4 grba(this Vector4 v) => new Vector4(v.y, v.x, v.z, v.w);
            
            public static Vector4 yxwx(this Vector4 v) => new Vector4(v.y, v.x, v.w, v.x);
            public static Vector4 grar(this Vector4 v) => new Vector4(v.y, v.x, v.w, v.x);
            
            public static Vector4 yxwy(this Vector4 v) => new Vector4(v.y, v.x, v.w, v.y);
            public static Vector4 grag(this Vector4 v) => new Vector4(v.y, v.x, v.w, v.y);
            
            public static Vector4 yxwz(this Vector4 v) => new Vector4(v.y, v.x, v.w, v.z);
            public static Vector4 grab(this Vector4 v) => new Vector4(v.y, v.x, v.w, v.z);
            
            public static Vector4 yxww(this Vector4 v) => new Vector4(v.y, v.x, v.w, v.w);
            public static Vector4 graa(this Vector4 v) => new Vector4(v.y, v.x, v.w, v.w);
            
            public static Vector4 yyxx(this Vector4 v) => new Vector4(v.y, v.y, v.x, v.x);
            public static Vector4 ggrr(this Vector4 v) => new Vector4(v.y, v.y, v.x, v.x);
            
            public static Vector4 yyxy(this Vector4 v) => new Vector4(v.y, v.y, v.x, v.y);
            public static Vector4 ggrg(this Vector4 v) => new Vector4(v.y, v.y, v.x, v.y);
            
            public static Vector4 yyxz(this Vector4 v) => new Vector4(v.y, v.y, v.x, v.z);
            public static Vector4 ggrb(this Vector4 v) => new Vector4(v.y, v.y, v.x, v.z);
            
            public static Vector4 yyxw(this Vector4 v) => new Vector4(v.y, v.y, v.x, v.w);
            public static Vector4 ggra(this Vector4 v) => new Vector4(v.y, v.y, v.x, v.w);
            
            public static Vector4 yyyx(this Vector4 v) => new Vector4(v.y, v.y, v.y, v.x);
            public static Vector4 gggr(this Vector4 v) => new Vector4(v.y, v.y, v.y, v.x);
            
            public static Vector4 yyyy(this Vector4 v) => new Vector4(v.y, v.y, v.y, v.y);
            public static Vector4 gggg(this Vector4 v) => new Vector4(v.y, v.y, v.y, v.y);
            
            public static Vector4 yyyz(this Vector4 v) => new Vector4(v.y, v.y, v.y, v.z);
            public static Vector4 gggb(this Vector4 v) => new Vector4(v.y, v.y, v.y, v.z);
            
            public static Vector4 yyyw(this Vector4 v) => new Vector4(v.y, v.y, v.y, v.w);
            public static Vector4 ggga(this Vector4 v) => new Vector4(v.y, v.y, v.y, v.w);
            
            public static Vector4 yyzx(this Vector4 v) => new Vector4(v.y, v.y, v.z, v.x);
            public static Vector4 ggbr(this Vector4 v) => new Vector4(v.y, v.y, v.z, v.x);
            
            public static Vector4 yyzy(this Vector4 v) => new Vector4(v.y, v.y, v.z, v.y);
            public static Vector4 ggbg(this Vector4 v) => new Vector4(v.y, v.y, v.z, v.y);
            
            public static Vector4 yyzz(this Vector4 v) => new Vector4(v.y, v.y, v.z, v.z);
            public static Vector4 ggbb(this Vector4 v) => new Vector4(v.y, v.y, v.z, v.z);
            
            public static Vector4 yyzw(this Vector4 v) => new Vector4(v.y, v.y, v.z, v.w);
            public static Vector4 ggba(this Vector4 v) => new Vector4(v.y, v.y, v.z, v.w);
            
            public static Vector4 yywx(this Vector4 v) => new Vector4(v.y, v.y, v.w, v.x);
            public static Vector4 ggar(this Vector4 v) => new Vector4(v.y, v.y, v.w, v.x);
            
            public static Vector4 yywy(this Vector4 v) => new Vector4(v.y, v.y, v.w, v.y);
            public static Vector4 ggag(this Vector4 v) => new Vector4(v.y, v.y, v.w, v.y);
            
            public static Vector4 yywz(this Vector4 v) => new Vector4(v.y, v.y, v.w, v.z);
            public static Vector4 ggab(this Vector4 v) => new Vector4(v.y, v.y, v.w, v.z);
            
            public static Vector4 yyww(this Vector4 v) => new Vector4(v.y, v.y, v.w, v.w);
            public static Vector4 ggaa(this Vector4 v) => new Vector4(v.y, v.y, v.w, v.w);
            
            public static Vector4 yzxx(this Vector4 v) => new Vector4(v.y, v.z, v.x, v.x);
            public static Vector4 gbrr(this Vector4 v) => new Vector4(v.y, v.z, v.x, v.x);
            
            public static Vector4 yzxy(this Vector4 v) => new Vector4(v.y, v.z, v.x, v.y);
            public static Vector4 gbrg(this Vector4 v) => new Vector4(v.y, v.z, v.x, v.y);
            
            public static Vector4 yzxz(this Vector4 v) => new Vector4(v.y, v.z, v.x, v.z);
            public static Vector4 gbrb(this Vector4 v) => new Vector4(v.y, v.z, v.x, v.z);
            
            public static Vector4 yzxw(this Vector4 v) => new Vector4(v.y, v.z, v.x, v.w);
            public static Vector4 gbra(this Vector4 v) => new Vector4(v.y, v.z, v.x, v.w);
            
            public static Vector4 yzyx(this Vector4 v) => new Vector4(v.y, v.z, v.y, v.x);
            public static Vector4 gbgr(this Vector4 v) => new Vector4(v.y, v.z, v.y, v.x);
            
            public static Vector4 yzyy(this Vector4 v) => new Vector4(v.y, v.z, v.y, v.y);
            public static Vector4 gbgg(this Vector4 v) => new Vector4(v.y, v.z, v.y, v.y);
            
            public static Vector4 yzyz(this Vector4 v) => new Vector4(v.y, v.z, v.y, v.z);
            public static Vector4 gbgb(this Vector4 v) => new Vector4(v.y, v.z, v.y, v.z);
            
            public static Vector4 yzyw(this Vector4 v) => new Vector4(v.y, v.z, v.y, v.w);
            public static Vector4 gbga(this Vector4 v) => new Vector4(v.y, v.z, v.y, v.w);
            
            public static Vector4 yzzx(this Vector4 v) => new Vector4(v.y, v.z, v.z, v.x);
            public static Vector4 gbbr(this Vector4 v) => new Vector4(v.y, v.z, v.z, v.x);
            
            public static Vector4 yzzy(this Vector4 v) => new Vector4(v.y, v.z, v.z, v.y);
            public static Vector4 gbbg(this Vector4 v) => new Vector4(v.y, v.z, v.z, v.y);
            
            public static Vector4 yzzz(this Vector4 v) => new Vector4(v.y, v.z, v.z, v.z);
            public static Vector4 gbbb(this Vector4 v) => new Vector4(v.y, v.z, v.z, v.z);
            
            public static Vector4 yzzw(this Vector4 v) => new Vector4(v.y, v.z, v.z, v.w);
            public static Vector4 gbba(this Vector4 v) => new Vector4(v.y, v.z, v.z, v.w);
            
            public static Vector4 yzwx(this Vector4 v) => new Vector4(v.y, v.z, v.w, v.x);
            public static Vector4 gbar(this Vector4 v) => new Vector4(v.y, v.z, v.w, v.x);
            
            public static Vector4 yzwy(this Vector4 v) => new Vector4(v.y, v.z, v.w, v.y);
            public static Vector4 gbag(this Vector4 v) => new Vector4(v.y, v.z, v.w, v.y);
            
            public static Vector4 yzwz(this Vector4 v) => new Vector4(v.y, v.z, v.w, v.z);
            public static Vector4 gbab(this Vector4 v) => new Vector4(v.y, v.z, v.w, v.z);
            
            public static Vector4 yzww(this Vector4 v) => new Vector4(v.y, v.z, v.w, v.w);
            public static Vector4 gbaa(this Vector4 v) => new Vector4(v.y, v.z, v.w, v.w);
            
            public static Vector4 ywxx(this Vector4 v) => new Vector4(v.y, v.w, v.x, v.x);
            public static Vector4 garr(this Vector4 v) => new Vector4(v.y, v.w, v.x, v.x);
            
            public static Vector4 ywxy(this Vector4 v) => new Vector4(v.y, v.w, v.x, v.y);
            public static Vector4 garg(this Vector4 v) => new Vector4(v.y, v.w, v.x, v.y);
            
            public static Vector4 ywxz(this Vector4 v) => new Vector4(v.y, v.w, v.x, v.z);
            public static Vector4 garb(this Vector4 v) => new Vector4(v.y, v.w, v.x, v.z);
            
            public static Vector4 ywxw(this Vector4 v) => new Vector4(v.y, v.w, v.x, v.w);
            public static Vector4 gara(this Vector4 v) => new Vector4(v.y, v.w, v.x, v.w);
            
            public static Vector4 ywyx(this Vector4 v) => new Vector4(v.y, v.w, v.y, v.x);
            public static Vector4 gagr(this Vector4 v) => new Vector4(v.y, v.w, v.y, v.x);
            
            public static Vector4 ywyy(this Vector4 v) => new Vector4(v.y, v.w, v.y, v.y);
            public static Vector4 gagg(this Vector4 v) => new Vector4(v.y, v.w, v.y, v.y);
            
            public static Vector4 ywyz(this Vector4 v) => new Vector4(v.y, v.w, v.y, v.z);
            public static Vector4 gagb(this Vector4 v) => new Vector4(v.y, v.w, v.y, v.z);
            
            public static Vector4 ywyw(this Vector4 v) => new Vector4(v.y, v.w, v.y, v.w);
            public static Vector4 gaga(this Vector4 v) => new Vector4(v.y, v.w, v.y, v.w);
            
            public static Vector4 ywzx(this Vector4 v) => new Vector4(v.y, v.w, v.z, v.x);
            public static Vector4 gabr(this Vector4 v) => new Vector4(v.y, v.w, v.z, v.x);
            
            public static Vector4 ywzy(this Vector4 v) => new Vector4(v.y, v.w, v.z, v.y);
            public static Vector4 gabg(this Vector4 v) => new Vector4(v.y, v.w, v.z, v.y);
            
            public static Vector4 ywzz(this Vector4 v) => new Vector4(v.y, v.w, v.z, v.z);
            public static Vector4 gabb(this Vector4 v) => new Vector4(v.y, v.w, v.z, v.z);
            
            public static Vector4 ywzw(this Vector4 v) => new Vector4(v.y, v.w, v.z, v.w);
            public static Vector4 gaba(this Vector4 v) => new Vector4(v.y, v.w, v.z, v.w);
            
            public static Vector4 ywwx(this Vector4 v) => new Vector4(v.y, v.w, v.w, v.x);
            public static Vector4 gaar(this Vector4 v) => new Vector4(v.y, v.w, v.w, v.x);
            
            public static Vector4 ywwy(this Vector4 v) => new Vector4(v.y, v.w, v.w, v.y);
            public static Vector4 gaag(this Vector4 v) => new Vector4(v.y, v.w, v.w, v.y);
            
            public static Vector4 ywwz(this Vector4 v) => new Vector4(v.y, v.w, v.w, v.z);
            public static Vector4 gaab(this Vector4 v) => new Vector4(v.y, v.w, v.w, v.z);
            
            public static Vector4 ywww(this Vector4 v) => new Vector4(v.y, v.w, v.w, v.w);
            public static Vector4 gaaa(this Vector4 v) => new Vector4(v.y, v.w, v.w, v.w);
            
            // ----
            
            public static Vector4 zxxx(this Vector4 v) => new Vector4(v.z, v.x, v.x, v.x);
            public static Vector4 brrr(this Vector4 v) => new Vector4(v.z, v.x, v.x, v.x);
            
            public static Vector4 zxxy(this Vector4 v) => new Vector4(v.z, v.x, v.x, v.y);
            public static Vector4 brrg(this Vector4 v) => new Vector4(v.z, v.x, v.x, v.y);
            
            public static Vector4 zxxz(this Vector4 v) => new Vector4(v.z, v.x, v.x, v.z);
            public static Vector4 brrb(this Vector4 v) => new Vector4(v.z, v.x, v.x, v.z);
            
            public static Vector4 zxxw(this Vector4 v) => new Vector4(v.z, v.x, v.x, v.w);
            public static Vector4 brra(this Vector4 v) => new Vector4(v.z, v.x, v.x, v.w);
            
            public static Vector4 zxyx(this Vector4 v) => new Vector4(v.z, v.x, v.y, v.x);
            public static Vector4 brgr(this Vector4 v) => new Vector4(v.z, v.x, v.y, v.x);
            
            public static Vector4 zxyy(this Vector4 v) => new Vector4(v.z, v.x, v.y, v.y);
            public static Vector4 brgg(this Vector4 v) => new Vector4(v.z, v.x, v.y, v.y);
            
            public static Vector4 zxyz(this Vector4 v) => new Vector4(v.z, v.x, v.y, v.z);
            public static Vector4 brgb(this Vector4 v) => new Vector4(v.z, v.x, v.y, v.z);
            
            public static Vector4 zxyw(this Vector4 v) => new Vector4(v.z, v.x, v.y, v.w);
            public static Vector4 brga(this Vector4 v) => new Vector4(v.z, v.x, v.y, v.w);
            
            public static Vector4 zxzx(this Vector4 v) => new Vector4(v.z, v.x, v.z, v.x);
            public static Vector4 brbr(this Vector4 v) => new Vector4(v.z, v.x, v.z, v.x);
            
            public static Vector4 zxzy(this Vector4 v) => new Vector4(v.z, v.x, v.z, v.y);
            public static Vector4 brbg(this Vector4 v) => new Vector4(v.z, v.x, v.z, v.y);
            
            public static Vector4 zxzz(this Vector4 v) => new Vector4(v.z, v.x, v.z, v.z);
            public static Vector4 brbb(this Vector4 v) => new Vector4(v.z, v.x, v.z, v.z);
            
            public static Vector4 zxzw(this Vector4 v) => new Vector4(v.z, v.x, v.z, v.w);
            public static Vector4 brba(this Vector4 v) => new Vector4(v.z, v.x, v.z, v.w);
            
            public static Vector4 zxwx(this Vector4 v) => new Vector4(v.z, v.x, v.w, v.x);
            public static Vector4 brar(this Vector4 v) => new Vector4(v.z, v.x, v.w, v.x);
            
            public static Vector4 zxwy(this Vector4 v) => new Vector4(v.z, v.x, v.w, v.y);
            public static Vector4 brag(this Vector4 v) => new Vector4(v.z, v.x, v.w, v.y);
            
            public static Vector4 zxwz(this Vector4 v) => new Vector4(v.z, v.x, v.w, v.z);
            public static Vector4 brab(this Vector4 v) => new Vector4(v.z, v.x, v.w, v.z);
            
            public static Vector4 zxww(this Vector4 v) => new Vector4(v.z, v.x, v.w, v.w);
            public static Vector4 braa(this Vector4 v) => new Vector4(v.z, v.x, v.w, v.w);
            
            public static Vector4 zyxx(this Vector4 v) => new Vector4(v.z, v.y, v.x, v.x);
            public static Vector4 bgrr(this Vector4 v) => new Vector4(v.z, v.y, v.x, v.x);
            
            public static Vector4 zyxy(this Vector4 v) => new Vector4(v.z, v.y, v.x, v.y);
            public static Vector4 bgrg(this Vector4 v) => new Vector4(v.z, v.y, v.x, v.y);
            
            public static Vector4 zyxz(this Vector4 v) => new Vector4(v.z, v.y, v.x, v.z);
            public static Vector4 bgrb(this Vector4 v) => new Vector4(v.z, v.y, v.x, v.z);
            
            public static Vector4 zyxw(this Vector4 v) => new Vector4(v.z, v.y, v.x, v.w);
            public static Vector4 bgra(this Vector4 v) => new Vector4(v.z, v.y, v.x, v.w);
            
            public static Vector4 zyyx(this Vector4 v) => new Vector4(v.z, v.y, v.y, v.x);
            public static Vector4 bggr(this Vector4 v) => new Vector4(v.z, v.y, v.y, v.x);
            
            public static Vector4 zyyy(this Vector4 v) => new Vector4(v.z, v.y, v.y, v.y);
            public static Vector4 bggg(this Vector4 v) => new Vector4(v.z, v.y, v.y, v.y);
            
            public static Vector4 zyyz(this Vector4 v) => new Vector4(v.z, v.y, v.y, v.z);
            public static Vector4 bggb(this Vector4 v) => new Vector4(v.z, v.y, v.y, v.z);
            
            public static Vector4 zyyw(this Vector4 v) => new Vector4(v.z, v.y, v.y, v.w);
            public static Vector4 bgga(this Vector4 v) => new Vector4(v.z, v.y, v.y, v.w);
            
            public static Vector4 zyzx(this Vector4 v) => new Vector4(v.z, v.y, v.z, v.x);
            public static Vector4 bgbr(this Vector4 v) => new Vector4(v.z, v.y, v.z, v.x);
            
            public static Vector4 zyzy(this Vector4 v) => new Vector4(v.z, v.y, v.z, v.y);
            public static Vector4 bgbg(this Vector4 v) => new Vector4(v.z, v.y, v.z, v.y);
            
            public static Vector4 zyzz(this Vector4 v) => new Vector4(v.z, v.y, v.z, v.z);
            public static Vector4 bgbb(this Vector4 v) => new Vector4(v.z, v.y, v.z, v.z);
            
            public static Vector4 zyzw(this Vector4 v) => new Vector4(v.z, v.y, v.z, v.w);
            public static Vector4 bgba(this Vector4 v) => new Vector4(v.z, v.y, v.z, v.w);
            
            public static Vector4 zywx(this Vector4 v) => new Vector4(v.z, v.y, v.w, v.x);
            public static Vector4 bgar(this Vector4 v) => new Vector4(v.z, v.y, v.w, v.x);
            
            public static Vector4 zywy(this Vector4 v) => new Vector4(v.z, v.y, v.w, v.y);
            public static Vector4 bgag(this Vector4 v) => new Vector4(v.z, v.y, v.w, v.y);
            
            public static Vector4 zywz(this Vector4 v) => new Vector4(v.z, v.y, v.w, v.z);
            public static Vector4 bgab(this Vector4 v) => new Vector4(v.z, v.y, v.w, v.z);
            
            public static Vector4 zyww(this Vector4 v) => new Vector4(v.z, v.y, v.w, v.w);
            public static Vector4 bgaa(this Vector4 v) => new Vector4(v.z, v.y, v.w, v.w);
            
            public static Vector4 zzxx(this Vector4 v) => new Vector4(v.z, v.z, v.x, v.x);
            public static Vector4 bbrr(this Vector4 v) => new Vector4(v.z, v.z, v.x, v.x);
            
            public static Vector4 zzxy(this Vector4 v) => new Vector4(v.z, v.z, v.x, v.y);
            public static Vector4 bbrg(this Vector4 v) => new Vector4(v.z, v.z, v.x, v.y);
            
            public static Vector4 zzxz(this Vector4 v) => new Vector4(v.z, v.z, v.x, v.z);
            public static Vector4 bbrb(this Vector4 v) => new Vector4(v.z, v.z, v.x, v.z);
            
            public static Vector4 zzxw(this Vector4 v) => new Vector4(v.z, v.z, v.x, v.w);
            public static Vector4 bbra(this Vector4 v) => new Vector4(v.z, v.z, v.x, v.w);
            
            public static Vector4 zzyx(this Vector4 v) => new Vector4(v.z, v.z, v.y, v.x);
            public static Vector4 bbgr(this Vector4 v) => new Vector4(v.z, v.z, v.y, v.x);
            
            public static Vector4 zzyy(this Vector4 v) => new Vector4(v.z, v.z, v.y, v.y);
            public static Vector4 bbgg(this Vector4 v) => new Vector4(v.z, v.z, v.y, v.y);
            
            public static Vector4 zzyz(this Vector4 v) => new Vector4(v.z, v.z, v.y, v.z);
            public static Vector4 bbgb(this Vector4 v) => new Vector4(v.z, v.z, v.y, v.z);
            
            public static Vector4 zzyw(this Vector4 v) => new Vector4(v.z, v.z, v.y, v.w);
            public static Vector4 bbga(this Vector4 v) => new Vector4(v.z, v.z, v.y, v.w);
            
            public static Vector4 zzzx(this Vector4 v) => new Vector4(v.z, v.z, v.z, v.x);
            public static Vector4 bbbr(this Vector4 v) => new Vector4(v.z, v.z, v.z, v.x);
            
            public static Vector4 zzzy(this Vector4 v) => new Vector4(v.z, v.z, v.z, v.y);
            public static Vector4 bbbg(this Vector4 v) => new Vector4(v.z, v.z, v.z, v.y);
            
            public static Vector4 zzzz(this Vector4 v) => new Vector4(v.z, v.z, v.z, v.z);
            public static Vector4 bbbb(this Vector4 v) => new Vector4(v.z, v.z, v.z, v.z);
            
            public static Vector4 zzzw(this Vector4 v) => new Vector4(v.z, v.z, v.z, v.w);
            public static Vector4 bbba(this Vector4 v) => new Vector4(v.z, v.z, v.z, v.w);
            
            public static Vector4 zzwx(this Vector4 v) => new Vector4(v.z, v.z, v.w, v.x);
            public static Vector4 bbar(this Vector4 v) => new Vector4(v.z, v.z, v.w, v.x);
            
            public static Vector4 zzwy(this Vector4 v) => new Vector4(v.z, v.z, v.w, v.y);
            public static Vector4 bbag(this Vector4 v) => new Vector4(v.z, v.z, v.w, v.y);
            
            public static Vector4 zzwz(this Vector4 v) => new Vector4(v.z, v.z, v.w, v.z);
            public static Vector4 bbab(this Vector4 v) => new Vector4(v.z, v.z, v.w, v.z);
            
            public static Vector4 zzww(this Vector4 v) => new Vector4(v.z, v.z, v.w, v.w);
            public static Vector4 bbaa(this Vector4 v) => new Vector4(v.z, v.z, v.w, v.w);
            
            public static Vector4 zwxx(this Vector4 v) => new Vector4(v.z, v.w, v.x, v.x);
            public static Vector4 barr(this Vector4 v) => new Vector4(v.z, v.w, v.x, v.x);
            
            public static Vector4 zwxy(this Vector4 v) => new Vector4(v.z, v.w, v.x, v.y);
            public static Vector4 barg(this Vector4 v) => new Vector4(v.z, v.w, v.x, v.y);
            
            public static Vector4 zwxz(this Vector4 v) => new Vector4(v.z, v.w, v.x, v.z);
            public static Vector4 barb(this Vector4 v) => new Vector4(v.z, v.w, v.x, v.z);
            
            public static Vector4 zwxw(this Vector4 v) => new Vector4(v.z, v.w, v.x, v.w);
            public static Vector4 bara(this Vector4 v) => new Vector4(v.z, v.w, v.x, v.w);
            
            public static Vector4 zwyx(this Vector4 v) => new Vector4(v.z, v.w, v.y, v.x);
            public static Vector4 bagr(this Vector4 v) => new Vector4(v.z, v.w, v.y, v.x);
            
            public static Vector4 zwyy(this Vector4 v) => new Vector4(v.z, v.w, v.y, v.y);
            public static Vector4 bagg(this Vector4 v) => new Vector4(v.z, v.w, v.y, v.y);
            
            public static Vector4 zwyz(this Vector4 v) => new Vector4(v.z, v.w, v.y, v.z);
            public static Vector4 bagb(this Vector4 v) => new Vector4(v.z, v.w, v.y, v.z);
            
            public static Vector4 zwyw(this Vector4 v) => new Vector4(v.z, v.w, v.y, v.w);
            public static Vector4 baga(this Vector4 v) => new Vector4(v.z, v.w, v.y, v.w);
            
            public static Vector4 zwzx(this Vector4 v) => new Vector4(v.z, v.w, v.z, v.x);
            public static Vector4 babr(this Vector4 v) => new Vector4(v.z, v.w, v.z, v.x);
            
            public static Vector4 zwzy(this Vector4 v) => new Vector4(v.z, v.w, v.z, v.y);
            public static Vector4 babg(this Vector4 v) => new Vector4(v.z, v.w, v.z, v.y);
            
            public static Vector4 zwzz(this Vector4 v) => new Vector4(v.z, v.w, v.z, v.z);
            public static Vector4 babb(this Vector4 v) => new Vector4(v.z, v.w, v.z, v.z);
            
            public static Vector4 zwzw(this Vector4 v) => new Vector4(v.z, v.w, v.z, v.w);
            public static Vector4 baba(this Vector4 v) => new Vector4(v.z, v.w, v.z, v.w);
            
            public static Vector4 zwwx(this Vector4 v) => new Vector4(v.z, v.w, v.w, v.x);
            public static Vector4 baar(this Vector4 v) => new Vector4(v.z, v.w, v.w, v.x);
            
            public static Vector4 zwwy(this Vector4 v) => new Vector4(v.z, v.w, v.w, v.y);
            public static Vector4 baag(this Vector4 v) => new Vector4(v.z, v.w, v.w, v.y);
            
            public static Vector4 zwwz(this Vector4 v) => new Vector4(v.z, v.w, v.w, v.z);
            public static Vector4 baab(this Vector4 v) => new Vector4(v.z, v.w, v.w, v.z);
            
            public static Vector4 zwww(this Vector4 v) => new Vector4(v.z, v.w, v.w, v.w);
            public static Vector4 baaa(this Vector4 v) => new Vector4(v.z, v.w, v.w, v.w);
            
            // ---
            
            public static Vector4 wxxx(this Vector4 v) => new Vector4(v.w, v.x, v.x, v.x);
            public static Vector4 arrr(this Vector4 v) => new Vector4(v.w, v.x, v.x, v.x);
            
            public static Vector4 wxxy(this Vector4 v) => new Vector4(v.w, v.x, v.x, v.y);
            public static Vector4 arrg(this Vector4 v) => new Vector4(v.w, v.x, v.x, v.y);
            
            public static Vector4 wxxz(this Vector4 v) => new Vector4(v.w, v.x, v.x, v.z);
            public static Vector4 arrb(this Vector4 v) => new Vector4(v.w, v.x, v.x, v.z);
            
            public static Vector4 wxxw(this Vector4 v) => new Vector4(v.w, v.x, v.x, v.w);
            public static Vector4 arra(this Vector4 v) => new Vector4(v.w, v.x, v.x, v.w);
            
            public static Vector4 wxyx(this Vector4 v) => new Vector4(v.w, v.x, v.y, v.x);
            public static Vector4 argr(this Vector4 v) => new Vector4(v.w, v.x, v.y, v.x);
            
            public static Vector4 wxyy(this Vector4 v) => new Vector4(v.w, v.x, v.y, v.y);
            public static Vector4 argg(this Vector4 v) => new Vector4(v.w, v.x, v.y, v.y);
            
            public static Vector4 wxyz(this Vector4 v) => new Vector4(v.w, v.x, v.y, v.z);
            public static Vector4 argb(this Vector4 v) => new Vector4(v.w, v.x, v.y, v.z);
            
            public static Vector4 wxyw(this Vector4 v) => new Vector4(v.w, v.x, v.y, v.w);
            public static Vector4 arga(this Vector4 v) => new Vector4(v.w, v.x, v.y, v.w);
            
            public static Vector4 wxzx(this Vector4 v) => new Vector4(v.w, v.x, v.z, v.x);
            public static Vector4 arbr(this Vector4 v) => new Vector4(v.w, v.x, v.z, v.x);
            
            public static Vector4 wxzy(this Vector4 v) => new Vector4(v.w, v.x, v.z, v.y);
            public static Vector4 arbg(this Vector4 v) => new Vector4(v.w, v.x, v.z, v.y);
            
            public static Vector4 wxzz(this Vector4 v) => new Vector4(v.w, v.x, v.z, v.z);
            public static Vector4 arbb(this Vector4 v) => new Vector4(v.w, v.x, v.z, v.z);
            
            public static Vector4 wxzw(this Vector4 v) => new Vector4(v.w, v.x, v.z, v.w);
            public static Vector4 arba(this Vector4 v) => new Vector4(v.w, v.x, v.z, v.w);
            
            public static Vector4 wxwx(this Vector4 v) => new Vector4(v.w, v.x, v.w, v.x);
            public static Vector4 arar(this Vector4 v) => new Vector4(v.w, v.x, v.w, v.x);
            
            public static Vector4 wxwy(this Vector4 v) => new Vector4(v.w, v.x, v.w, v.y);
            public static Vector4 arag(this Vector4 v) => new Vector4(v.w, v.x, v.w, v.y);
            
            public static Vector4 wxwz(this Vector4 v) => new Vector4(v.w, v.x, v.w, v.z);
            public static Vector4 arab(this Vector4 v) => new Vector4(v.w, v.x, v.w, v.z);
            
            public static Vector4 wxww(this Vector4 v) => new Vector4(v.w, v.x, v.w, v.w);
            public static Vector4 araa(this Vector4 v) => new Vector4(v.w, v.x, v.w, v.w);
            
            public static Vector4 wyxx(this Vector4 v) => new Vector4(v.w, v.y, v.x, v.x);
            public static Vector4 agrr(this Vector4 v) => new Vector4(v.w, v.y, v.x, v.x);
            
            public static Vector4 wyxy(this Vector4 v) => new Vector4(v.w, v.y, v.x, v.y);
            public static Vector4 agrg(this Vector4 v) => new Vector4(v.w, v.y, v.x, v.y);
            
            public static Vector4 wyxz(this Vector4 v) => new Vector4(v.w, v.y, v.x, v.z);
            public static Vector4 agrb(this Vector4 v) => new Vector4(v.w, v.y, v.x, v.z);
            
            public static Vector4 wyxw(this Vector4 v) => new Vector4(v.w, v.y, v.x, v.w);
            public static Vector4 agra(this Vector4 v) => new Vector4(v.w, v.y, v.x, v.w);
            
            public static Vector4 wyyx(this Vector4 v) => new Vector4(v.w, v.y, v.y, v.x);
            public static Vector4 aggr(this Vector4 v) => new Vector4(v.w, v.y, v.y, v.x);
            
            public static Vector4 wyyy(this Vector4 v) => new Vector4(v.w, v.y, v.y, v.y);
            public static Vector4 aggg(this Vector4 v) => new Vector4(v.w, v.y, v.y, v.y);
            
            public static Vector4 wyyz(this Vector4 v) => new Vector4(v.w, v.y, v.y, v.z);
            public static Vector4 aggb(this Vector4 v) => new Vector4(v.w, v.y, v.y, v.z);
            
            public static Vector4 wyyw(this Vector4 v) => new Vector4(v.w, v.y, v.y, v.w);
            public static Vector4 agga(this Vector4 v) => new Vector4(v.w, v.y, v.y, v.w);
            
            public static Vector4 wyzx(this Vector4 v) => new Vector4(v.w, v.y, v.z, v.x);
            public static Vector4 agbr(this Vector4 v) => new Vector4(v.w, v.y, v.z, v.x);
            
            public static Vector4 wyzy(this Vector4 v) => new Vector4(v.w, v.y, v.z, v.y);
            public static Vector4 agbg(this Vector4 v) => new Vector4(v.w, v.y, v.z, v.y);
            
            public static Vector4 wyzz(this Vector4 v) => new Vector4(v.w, v.y, v.z, v.z);
            public static Vector4 agbb(this Vector4 v) => new Vector4(v.w, v.y, v.z, v.z);
            
            public static Vector4 wyzw(this Vector4 v) => new Vector4(v.w, v.y, v.z, v.w);
            public static Vector4 agba(this Vector4 v) => new Vector4(v.w, v.y, v.z, v.w);
            
            public static Vector4 wywx(this Vector4 v) => new Vector4(v.w, v.y, v.w, v.x);
            public static Vector4 agar(this Vector4 v) => new Vector4(v.w, v.y, v.w, v.x);
            
            public static Vector4 wywy(this Vector4 v) => new Vector4(v.w, v.y, v.w, v.y);
            public static Vector4 agag(this Vector4 v) => new Vector4(v.w, v.y, v.w, v.y);
            
            public static Vector4 wywz(this Vector4 v) => new Vector4(v.w, v.y, v.w, v.z);
            public static Vector4 agab(this Vector4 v) => new Vector4(v.w, v.y, v.w, v.z);
            
            public static Vector4 wyww(this Vector4 v) => new Vector4(v.w, v.y, v.w, v.w);
            public static Vector4 agaa(this Vector4 v) => new Vector4(v.w, v.y, v.w, v.w);
            
            public static Vector4 wzxx(this Vector4 v) => new Vector4(v.w, v.z, v.x, v.x);
            public static Vector4 abrr(this Vector4 v) => new Vector4(v.w, v.z, v.x, v.x);
            
            public static Vector4 wzxy(this Vector4 v) => new Vector4(v.w, v.z, v.x, v.y);
            public static Vector4 abrg(this Vector4 v) => new Vector4(v.w, v.z, v.x, v.y);
            
            public static Vector4 wzxz(this Vector4 v) => new Vector4(v.w, v.z, v.x, v.z);
            public static Vector4 abrb(this Vector4 v) => new Vector4(v.w, v.z, v.x, v.z);
            
            public static Vector4 wzxw(this Vector4 v) => new Vector4(v.w, v.z, v.x, v.w);
            public static Vector4 abra(this Vector4 v) => new Vector4(v.w, v.z, v.x, v.w);
            
            public static Vector4 wzyx(this Vector4 v) => new Vector4(v.w, v.z, v.y, v.x);
            public static Vector4 abgr(this Vector4 v) => new Vector4(v.w, v.z, v.y, v.x);
            
            public static Vector4 wzyy(this Vector4 v) => new Vector4(v.w, v.z, v.y, v.y);
            public static Vector4 abgg(this Vector4 v) => new Vector4(v.w, v.z, v.y, v.y);
            
            public static Vector4 wzyz(this Vector4 v) => new Vector4(v.w, v.z, v.y, v.z);
            public static Vector4 abgb(this Vector4 v) => new Vector4(v.w, v.z, v.y, v.z);
            
            public static Vector4 wzyw(this Vector4 v) => new Vector4(v.w, v.z, v.y, v.w);
            public static Vector4 abga(this Vector4 v) => new Vector4(v.w, v.z, v.y, v.w);
            
            public static Vector4 wzzx(this Vector4 v) => new Vector4(v.w, v.z, v.z, v.x);
            public static Vector4 abbr(this Vector4 v) => new Vector4(v.w, v.z, v.z, v.x);
            
            public static Vector4 wzzy(this Vector4 v) => new Vector4(v.w, v.z, v.z, v.y);
            public static Vector4 abbg(this Vector4 v) => new Vector4(v.w, v.z, v.z, v.y);
            
            public static Vector4 wzzz(this Vector4 v) => new Vector4(v.w, v.z, v.z, v.z);
            public static Vector4 abbb(this Vector4 v) => new Vector4(v.w, v.z, v.z, v.z);
            
            public static Vector4 wzzw(this Vector4 v) => new Vector4(v.w, v.z, v.z, v.w);
            public static Vector4 abba(this Vector4 v) => new Vector4(v.w, v.z, v.z, v.w);
            
            public static Vector4 wzwx(this Vector4 v) => new Vector4(v.w, v.z, v.w, v.x);
            public static Vector4 abar(this Vector4 v) => new Vector4(v.w, v.z, v.w, v.x);
            
            public static Vector4 wzwy(this Vector4 v) => new Vector4(v.w, v.z, v.w, v.y);
            public static Vector4 abag(this Vector4 v) => new Vector4(v.w, v.z, v.w, v.y);
            
            public static Vector4 wzwz(this Vector4 v) => new Vector4(v.w, v.z, v.w, v.z);
            public static Vector4 abab(this Vector4 v) => new Vector4(v.w, v.z, v.w, v.z);
            
            public static Vector4 wzww(this Vector4 v) => new Vector4(v.w, v.z, v.w, v.w);
            public static Vector4 abaa(this Vector4 v) => new Vector4(v.w, v.z, v.w, v.w);
            
            public static Vector4 wwxx(this Vector4 v) => new Vector4(v.w, v.w, v.x, v.x);
            public static Vector4 aarr(this Vector4 v) => new Vector4(v.w, v.w, v.x, v.x);
            
            public static Vector4 wwxy(this Vector4 v) => new Vector4(v.w, v.w, v.x, v.y);
            public static Vector4 aarg(this Vector4 v) => new Vector4(v.w, v.w, v.x, v.y);
            
            public static Vector4 wwxz(this Vector4 v) => new Vector4(v.w, v.w, v.x, v.z);
            public static Vector4 aarb(this Vector4 v) => new Vector4(v.w, v.w, v.x, v.z);
            
            public static Vector4 wwxw(this Vector4 v) => new Vector4(v.w, v.w, v.x, v.w);
            public static Vector4 aara(this Vector4 v) => new Vector4(v.w, v.w, v.x, v.w);
            
            public static Vector4 wwyx(this Vector4 v) => new Vector4(v.w, v.w, v.y, v.x);
            public static Vector4 aagr(this Vector4 v) => new Vector4(v.w, v.w, v.y, v.x);
            
            public static Vector4 wwyy(this Vector4 v) => new Vector4(v.w, v.w, v.y, v.y);
            public static Vector4 aagg(this Vector4 v) => new Vector4(v.w, v.w, v.y, v.y);
            
            public static Vector4 wwyz(this Vector4 v) => new Vector4(v.w, v.w, v.y, v.z);
            public static Vector4 aagb(this Vector4 v) => new Vector4(v.w, v.w, v.y, v.z);
            
            public static Vector4 wwyw(this Vector4 v) => new Vector4(v.w, v.w, v.y, v.w);
            public static Vector4 aaga(this Vector4 v) => new Vector4(v.w, v.w, v.y, v.w);
            
            public static Vector4 wwzx(this Vector4 v) => new Vector4(v.w, v.w, v.z, v.x);
            public static Vector4 aabr(this Vector4 v) => new Vector4(v.w, v.w, v.z, v.x);
            
            public static Vector4 wwzy(this Vector4 v) => new Vector4(v.w, v.w, v.z, v.y);
            public static Vector4 aabg(this Vector4 v) => new Vector4(v.w, v.w, v.z, v.y);
            
            public static Vector4 wwzz(this Vector4 v) => new Vector4(v.w, v.w, v.z, v.z);
            public static Vector4 aabb(this Vector4 v) => new Vector4(v.w, v.w, v.z, v.z);
            
            public static Vector4 wwzw(this Vector4 v) => new Vector4(v.w, v.w, v.z, v.w);
            public static Vector4 aaba(this Vector4 v) => new Vector4(v.w, v.w, v.z, v.w);
            
            public static Vector4 wwwx(this Vector4 v) => new Vector4(v.w, v.w, v.w, v.x);
            public static Vector4 aaar(this Vector4 v) => new Vector4(v.w, v.w, v.w, v.x);
            
            public static Vector4 wwwy(this Vector4 v) => new Vector4(v.w, v.w, v.w, v.y);
            public static Vector4 aaag(this Vector4 v) => new Vector4(v.w, v.w, v.w, v.y);
            
            public static Vector4 wwwz(this Vector4 v) => new Vector4(v.w, v.w, v.w, v.z);
            public static Vector4 aaab(this Vector4 v) => new Vector4(v.w, v.w, v.w, v.z);
            
            public static Vector4 wwww(this Vector4 v) => new Vector4(v.w, v.w, v.w, v.w);
            public static Vector4 aaaa(this Vector4 v) => new Vector4(v.w, v.w, v.w, v.w);
            #endregion 
    }
}