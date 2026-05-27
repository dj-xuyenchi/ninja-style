using UnityEngine;
using System.Collections;

namespace Assets.Script.Constant
{
	public enum StatEnum
	{
		HP = 0, // Máu
        CHAKRA = 1, // Chakra
        PF = 2, // Thể lực (Phái thể thuật)
		NOI_CONG =3, // Nội công
		NGOAI_CONG = 4, // Ngoại công
		PT_NOI_PHONG = 5, // Nội phòng
		PT_NGOAI_PHONG = 6, // Ngoại phòng
		CHI_MANG = 7, // Chí mạng
		NE_TRANH =8, // Né tránh
		TY_LE_XUAT_CHIEU = 9, // Tỷ lệ xuất chiêu
		CHINH_XAC = 10, // Chính xác
		TOC_DO_XUAT_CHIEU = 11, // Tốc độ xuất chiêu
		TOC_DO_DI_CHUYEN = 12, // Tốc độ di chuyển
		TOC_DO_DANH = 13, // Tốc độ đánh

        // Các chỉ số đặc biệt
		HO_TRO_TAN_CONG_NOI = 14, // Hỗ trợ tấn công nội công
	    HO_TRO_TAN_CONG_NGOAI = 15, // Hỗ trợ tấn công ngoại công
		PHAN_DON_NOI = 16, // Phản đòn nội công
		PHAN_DON_NGOAI = 17, // Phản đòn ngoại công
		GIAM_THOI_GIAN_THO_THUONG = 18, // Giảm thời gian thọ thương
		GIAM_THO_THUONG = 19, // Giảm thọ thương
		TANG_THOI_GIAN_THUONG_DUOC = 20, // Tăng thời gian thương dược
		GIAM_THOI_GIAN_HIEU_UNG = 21, // Giảm thời gian hiệu ứng
		KHANG_HIEU_UNG = 22, // Kháng hiệu ứng
		BO_QUA_PHONG_NGU_DOI_PHUONG = 23, // Bỏ qua phòng ngự đối phương

    }
}