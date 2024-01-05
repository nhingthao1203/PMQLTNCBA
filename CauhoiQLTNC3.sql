CREATE TABLE CauHoi_Gop (
MaCH int NOT NULL,
NoiDung nvarchar(300),
HinhThucCH char(2),
Hinh image,
MaMon nvarchar(10),
DoKho char(1),
DapAn_A nvarchar(300),
DapAn_B nvarchar(300),
DapAn_C nvarchar(300),
DapAn_D nvarchar(300),
DapAn char(1),
primary key clustered (MaCH)
)


INSERT INTO Khoa (MaKhoa, TenKhoa)
VALUES 
('KHOA01', N'Khối 10'),
('KHOA02', N'Khối 11'),
('KHOA03', N'Khối 12');

-- Dữ liệu mẫu cho bảng Lop tương ứng với bảng Khoa
INSERT INTO Lop (MaLop, TenLop, MaKhoa)
VALUES 
('Lop001', N'10A1', 'KHOA01'), -- Lớp 10A1 thuộc khối 10
('Lop002', N'10A2', 'KHOA01'),
('Lop003', N'10B1', 'KHOA01'),
('Lop004', N'10B2', 'KHOA01'),
('Lop005', N'11A1', 'KHOA02'), -- Lớp 11A1 thuộc khối 11
('Lop006', N'11A2', 'KHOA02'),
('Lop007', N'11B1', 'KHOA02'),
('Lop008', N'11B2', 'KHOA02'),
('Lop009', N'12A1', 'KHOA03'), -- Lớp 12A1 thuộc khối 12
('Lop010', N'12A2', 'KHOA03'),
('Lop011', N'12B1', 'KHOA03'),
('Lop012', N'12B2', 'KHOA03'),
('Lop013', N'10C1', 'KHOA01'),
('Lop014', N'10C2', 'KHOA01'),
('Lop015', N'11C1', 'KHOA02'),
('Lop016', N'11C2', 'KHOA02'),
('Lop017', N'12C1', 'KHOA03'),
('Lop018', N'12C2', 'KHOA03'),
('Lop019', N'10D1', 'KHOA01'),
('Lop020', N'10D2', 'KHOA01');


INSERT INTO ThiSinh (MaTS, Ten, DN, MK, NgaySinh, Lop, Khoa, HinhAnh, TrangThai, Quyen, Mess)
VALUES 
('TS001', N'Nguyễn Văn A', 'nguyenvana', 'password123', '1998-01-01', 'Lop001', 'KHOA01', NULL, 1, 1, NULL),
('TS002', N'Trần Thị B', 'tranthib', 'abc@123', '1999-05-10', 'Lop002', 'KHOA01', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS003', N'Lê Hoàng C', 'lehoangc', 'pass456', '2000-12-20', 'Lop003', 'KHOA01', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS004', N'Phạm Thị D', 'phamthid', 'user567', '1997-08-15', 'Lop004', 'KHOA01', NULL, 1, 1, NULL),
('TS005', N'Trương Văn E', 'truongvane', '123456', '1996-03-25', 'Lop005', 'KHOA02', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS006', N'Huỳnh Thị F', 'huynhthif', 'pass789', '2002-11-05', 'Lop006', 'KHOA02', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS007', N'Võ Văn G', 'vovang', 'pass123', '1995-09-30', 'Lop007', 'KHOA02', NULL, 1, 1, NULL),
('TS008', N'Đặng Thị H', 'dangthih', 'abc123', '2003-07-20', 'Lop008', 'KHOA02', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS009', N'Lý Văn I', 'lyvani', 'password789', '1994-04-18', 'Lop009', 'KHOA03', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS010', N'Ngô Thị K', 'ngothik', 'pass4567', '2001-02-28', 'Lop010', 'KHOA03', NULL, 1, 1, NULL),
('TS011', N'Tran Van L', 'tranvanl', 'pass1234', '1998-10-10', 'Lop011', 'KHOA03', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS012', N'Hoang Thi M', 'hoangthim', 'pass7890', '2000-06-15', 'Lop012', 'KHOA03', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS013', N'Đặng Văn N', 'dangvann', 'pass@123', '1997-04-25', 'Lop013', 'KHOA01', NULL, 1, 1, NULL),
('TS014', N'Trần Thị O', 'tranthio', 'pass#456', '1996-11-30', 'Lop014', 'KHOA01', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS015', N'Lê Văn P', 'levanp', 'pass&789', '2002-09-05', 'Lop015', 'KHOA02', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS016', N'Hồ Thị Q', 'hothiq', 'pass12345', '1995-07-15', 'Lop016', 'KHOA02', NULL, 1, 1, NULL),
('TS017', N'Phan Văn R', 'phanvanr', 'pass9876', '2003-03-20', 'Lop017', 'KHOA03', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS018', N'Vũ Thị S', 'vuthis', 'pass@987', '1999-01-12', 'Lop018', 'KHOA03', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS019', N'Hoàng Văn T', 'hoangvant', 'pass#654', '1994-12-03', 'Lop019', 'KHOA01', NULL, 1, 1, NULL),
('TS020', N'Nguyễn Thị U', 'nguyenthieu', 'pass@321', '2001-08-20', 'Lop020', 'KHOA01', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS021', N'Trần Văn X', 'tranvanx', 'pass1234', '1998-01-01', 'Lop001', 'KHOA01', NULL, 1, 1, NULL),
('TS022', N'Nguyễn Thị Y', 'nguyenthiy', 'abc@123', '1999-05-10', 'Lop002', 'KHOA01', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS023', N'Hồ Văn Z', 'hovanz', 'pass456', '2000-12-20', 'Lop003', 'KHOA01', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS024', N'Lê Thị M', 'lethim', 'user567', '1997-08-15', 'Lop004', 'KHOA01', NULL, 1, 1, NULL),
('TS025', N'Phạm Văn N', 'phamvann', '123456', '1996-03-25', 'Lop005', 'KHOA02', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS026', N'Trần Thị P', 'tranthip', 'pass789', '2002-11-05', 'Lop006', 'KHOA02', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS027', N'Huỳnh Văn Q', 'huynhvanq', 'pass123', '1995-09-30', 'Lop007', 'KHOA02', NULL, 1, 1, NULL),
('TS028', N'Đặng Thị R', 'dangthir', 'abc123', '2003-07-20', 'Lop008', 'KHOA02', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS029', N'Lý Văn S', 'lyvans', 'password789', '1994-04-18', 'Lop009', 'KHOA03', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS030', N'Ngô Thị T', 'ngothit', 'pass4567', '2001-02-28', 'Lop010', 'KHOA03', NULL, 1, 1, NULL),
('TS031', N'Tran Van U', 'tranvanu', 'pass1234', '1998-10-10', 'Lop011', 'KHOA03', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS032', N'Hoang Thi V', 'hoangthiv', 'pass7890', '2000-06-15', 'Lop012', 'KHOA03', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS033', N'Đặng Văn X', 'dangvanx', 'pass@123', '1997-04-25', 'Lop013', 'KHOA01', NULL, 1, 1, NULL),
('TS034', N'Trần Thị Y', 'tranthiy', 'pass#456', '1996-11-30', 'Lop014', 'KHOA01', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS035', N'Lê Văn Z', 'levanz', 'pass&789', '2002-09-05', 'Lop015', 'KHOA02', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS036', N'Hồ Thị M', 'hothim', 'pass12345', '1995-07-15', 'Lop016', 'KHOA02', NULL, 1, 1, NULL),
('TS037', N'Phan Văn N', 'phanvann', 'pass9876', '2003-03-20', 'Lop017', 'KHOA03', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS038', N'Vũ Thị O', 'vuthio', 'pass@987', '1999-01-12', 'Lop018', 'KHOA03', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS039', N'Hoàng Văn P', 'hoangvanp', 'pass#654', '1994-12-03', 'Lop019', 'KHOA01', NULL, 1, 1, NULL),
('TS040', N'Nguyễn Thị Q', 'nguyenthieus', 'pass@321', '2001-08-20', 'Lop020', 'KHOA01', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS041', N'Phạm Thị X', 'phamthix', 'pass1234', '1998-01-01', 'Lop001', 'KHOA01', NULL, 1, 1, NULL),
('TS042', N'Nguyễn Thị Y', 'nguyenthiy', 'abc@123', '1999-05-10', 'Lop002', 'KHOA01', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS043', N'Tran Văn Z', 'tranvanz', 'pass456', '2000-12-20', 'Lop003', 'KHOA01', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS044', N'Lê Thị M', 'lethim', 'user567', '1997-08-15', 'Lop004', 'KHOA01', NULL, 1, 1, NULL),
('TS045', N'Phạm Văn N', 'phamvann', '123456', '1996-03-25', 'Lop005', 'KHOA02', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS046', N'Trần Thị P', 'tranthip', 'pass789', '2002-11-05', 'Lop006', 'KHOA02', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS047', N'Huỳnh Văn Q', 'huynhvanq', 'pass123', '1995-09-30', 'Lop007', 'KHOA02', NULL, 1, 1, NULL),
('TS048', N'Đặng Thị R', 'dangthir', 'abc123', '2003-07-20', 'Lop008', 'KHOA02', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS049', N'Lý Văn S', 'lyvans', 'password789', '1994-04-18', 'Lop009', 'KHOA03', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS050', N'Ngô Thị T', 'ngothit', 'pass4567', '2001-02-28', 'Lop010', 'KHOA03', NULL, 1, 1, NULL),
('TS051', N'Tran Van U', 'tranvanu', 'pass1234', '1998-10-10', 'Lop011', 'KHOA03', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS052', N'Hoang Thi V', 'hoangthiv', 'pass7890', '2000-06-15', 'Lop012', 'KHOA03', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS053', N'Đặng Văn X', 'dangvanx', 'pass@123', '1997-04-25', 'Lop013', 'KHOA01', NULL, 1, 1, NULL),
('TS054', N'Trần Thị Y', 'tranthiy', 'pass#456', '1996-11-30', 'Lop014', 'KHOA01', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS055', N'Lê Văn Z', 'levanz', 'pass&789', '2002-09-05', 'Lop015', 'KHOA02', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS056', N'Hồ Thị M', 'hothim', 'pass12345', '1995-07-15', 'Lop016', 'KHOA02', NULL, 1, 1, NULL),
('TS057', N'Phan Văn N', 'phanvann', 'pass9876', '2003-03-20', 'Lop017', 'KHOA03', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.'),
('TS058', N'Vũ Thị O', 'vuthio', 'pass@987', '1999-01-12', 'Lop018', 'KHOA03', NULL, 0, 0, N'Bạn đã bị cấm đăng nhập.'),
('TS059', N'Hoàng Văn P', 'hoangvanp', 'pass#654', '1994-12-03', 'Lop019', 'KHOA01', NULL, 1, 1, NULL),
('TS060', N'Nguyễn Thị Q', 'nguyenthieus', 'pass@321', '2001-08-20', 'Lop020', 'KHOA01', NULL, 1, 0, N'Bạn đã bị đình chỉ tạm thời.');

-- Tạo 10 nhân viên và ánh xạ với các bảng đã có
INSERT INTO NhanVien (MaNV, Ten, DN, MK, NgaySinh, DonViCongTac, Quyen, PhanQuyen, HinhAnh)
VALUES 
('NV001', N'Nguyễn Văn P', 'nguyenvanp', 'pass123', '1985-01-01', 'KHOA01', 1, '1', NULL),
('NV002', N'Trần Thị Q', 'tranthiq', 'abc@123', '1990-05-10', 'KHOA02', 1, '2', NULL),
('NV003', N'Lê Văn R', 'levanr', 'pass456', '1988-12-20', 'KHOA03', 1, '3', NULL),
('NV004', N'Phạm Thị S', 'phamthis', 'user567', '1987-08-15', 'KHOA01', 1, '3', NULL),
('NV005', N'Trương Văn T', 'truongvant', '123456', '1992-03-25', 'KHOA02', 1, '3', NULL),
('NV006', N'Huỳnh Thị U', 'huynhthiu', 'pass789', '1991-11-05', 'KHOA03', 1, '3', NULL),
('NV007', N'Võ Văn V', 'vovanv', 'pass123', '1989-09-30', 'KHOA01', 1, '3', NULL),
('NV008', N'Đặng Thị X', 'dangthix', 'abc123', '1993-07-20', 'KHOA02', 1, '3', NULL),
('NV009', N'Lý Văn Y', 'lyvany', 'password789', '1986-04-18', 'KHOA03', 1, '3', NULL),
('NV010', N'Ngô Thị Z', 'ngothiz', 'pass4567', '1995-02-28', 'KHOA01', 1, '3', NULL);

-- Tạo 12 môn học cho cấp trung học
INSERT INTO Mon (MaMon, Ten)
VALUES 
('MH001', N'Toán'),
('MH002', N'Văn'),
('MH003', N'Lịch sử'),
('MH004', N'Địa lý'),
('MH005', N'Tiếng Anh'),
('MH006', N'Hóa học'),
('MH007', N'Sinh học'),
('MH008', N'Vật lý'),
('MH009', N'Tin học'),
('MH010', N'Giáo dục công dân'),
('MH011', N'Thể dục'),
('MH012', N'Âm nhạc');

CREATE TABLE CauHoi_Gop (
    MaCH int NOT NULL,  
    NoiDung nvarchar(300),
    HinhThucCH char(2),  
    Hinh image,  
    MaMon nvarchar(10),
    DoKho char(1),
    DapAn_A nvarchar(300),
    DapAn_B nvarchar(300),
    DapAn_C nvarchar(300),
    DapAn_D nvarchar(300),
    DapAn char(1),
    primary key clustered (MaCH)
)

-- Thêm 30 câu hỏi mẫu về môn Toán (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(1, N'Câu 1: Tính giá trị của biểu thức: 2 * (5 + 3) - 4', 'M', NULL, 'MH001', '1', N'12', N'16', N'20', N'22', 'A'),
(2, N'Câu 2: Phân tích thừa số nguyên tố của số 210', 'M', NULL, 'MH001', '2', N'2^2 * 3 * 5 * 7', N'2 * 3 * 5 * 7', N'2 * 3^2 * 5', N'2^2 * 3 * 5^2', 'A'),
(3, N'Câu 3: Tìm số đối của số 3/5', 'M', NULL, 'MH001', '1', N'5/3', N'3/5', N'5/3', N'5', 'B'),
(4, N'Câu 4: Giải phương trình: x^2 - 5x + 6 = 0', 'M', NULL, 'MH001', '2', N'x = 2, x = 3', N'x = 4, x = 1', N'x = 2, x = -3', N'x = 5, x = 1', 'A'),
(5, N'Câu 5: Tính diện tích hình thang có đáy lớn 8, đáy nhỏ 4 và chiều cao 6', 'M', NULL, 'MH001', '2', N'24', N'18', N'16', N'12', 'A'),
(6, N'Câu 6: Giải bài toán: Có 3 quả táo, 5 quả lê và 4 quả cam, hỏi có bao nhiêu cách chọn 3 quả hoa quả từ các quả trên?', 'M', NULL, 'MH001', '3', N'30', N'60', N'90', N'120', 'D'),
(7, N'Câu 7: Tìm giá trị lớn nhất của hàm số y = x^2 - 4x + 3', 'M', NULL, 'MH001', '3', N'5', N'6', N'4', N'3', 'A'),
(8, N'Câu 8: Tính tích có hai thừa số cùng số ước chung lớn nhất bằng 12', 'M', NULL, 'MH001', '2', N'20', N'30', N'24', N'18', 'C'),
(9, N'Câu 9: Giải bất phương trình: |2x - 5| = 3', 'M', NULL, 'MH001', '2', N'x = 1, x = 4', N'x = 8, x = -1', N'x = 2, x = 3', N'x = 7, x = -2', 'A'),
(10, N'Câu 10: Tính chu vi tam giác có ba cạnh lần lượt là 3 cm, 4 cm, và 5 cm', 'M', NULL, 'MH001', '1', N'11 cm', N'12 cm', N'13 cm', N'14 cm', 'C'),
(11, N'Câu 1: Tính giá trị của biểu thức: log₄(64)', 'M', NULL, 'MH001', '1', N'2', N'3', N'4', N'5', 'C'),
(12, N'Câu 2: Tìm giá trị lớn nhất của hàm số y = x³ - 6x² + 9x + 8', 'M', NULL, 'MH001', '3', N'9', N'8', N'7', N'6', 'A'),
(13, N'Câu 3: Giải phương trình: 2x² + 5x - 3 = 0', 'M', NULL, 'MH001', '2', N'x = -3 hoặc x = 1/2', N'x = 2 hoặc x = -3/2', N'x = 3 hoặc x = -1/2', N'x = -2 hoặc x = 3/2', 'A'),
(14, N'Câu 4: Tìm đạo hàm của hàm số y = sin(2x) - x² + 3', 'M', NULL, 'MH001', '3', N'cos(2x) - 2x', N'cos(2x) - x', N'2cos(2x) - x²', N'2cos(2x) - 2x', 'A'),
(15, N'Câu 5: Tính tích có hai thừa số cùng số ước chung lớn nhất bằng 24', 'M', NULL, 'MH001', '2', N'40', N'48', N'32', N'36', 'C'),
(16, N'Câu 6: Giải bất phương trình: |x - 3| < 5', 'M', NULL, 'MH001', '2', N'-2 < x < 8', N'-8 < x < 2', N'x > 8', N'x > -2', 'A'),
(17, N'Câu 7: Tính diện tích hình tròn có bán kính 5', 'M', NULL, 'MH001', '1', N'25π', N'10π', N'20π', N'50π', 'A'),
(18, N'Câu 8: Tính tổng của dãy số: 1 + 4 + 7 + ... + 100', 'M', NULL, 'MH001', '2', N'1715', N'1675', N'1765', N'1705', 'A'),
(19, N'Câu 9: Tìm giá trị nhỏ nhất của hàm số y = x² - 4x + 5', 'M', NULL, 'MH001', '3', N'1', N'2', N'0', N'-1', 'A'),
(20, N'Câu 10: Giải hệ phương trình: { 2x - y = 1, x + 3y = 7 }', 'M', NULL, 'MH001', '2', N'x = 2, y = 3', N'x = 3, y = 2', N'x = 1, y = 4', N'x = 4, y = 1', 'A'),
(21, N'Câu 1: Tính giá trị của biểu thức: lim(x→2) (x² - 4) / (x - 2)', 'M', NULL, 'MH001', '3', N'4', N'5', N'6', N'7', 'A'),
(22, N'Câu 2: Tìm phương trình tiếp tuyến của đồ thị hàm số y = x³ - 3x² + 2x + 5 tại điểm có hoành độ x = 1', 'M', NULL, 'MH001', '3', N'y = -2x + 6', N'y = -3x + 8', N'y = -x + 4', N'y = -4x + 10', 'B'),
(23, N'Câu 3: Giải phương trình logₓ(2x - 1) = 1', 'M', NULL, 'MH001', '3', N'x = 3/2', N'x = 2', N'x = 3', N'x = 4', 'A'),
(24, N'Câu 4: Tìm giá trị nhỏ nhất của hàm số y = x³ - 3x² + 3x - 1', 'M', NULL, 'MH001', '3', N'-3/4', N'-1', N'1/4', N'1', 'C'),
(25, N'Câu 5: Tính đạo hàm của hàm số y = e^x + x³ - 5x + 2', 'M', NULL, 'MH001', '3', N'e^x + 3x² - 5', N'e^x + 3x² - 5x', N'e^x + 3x² - 4', N'e^x + 3x² - 6x', 'A'),
(26, N'Câu 6: Tính tích có hai thừa số cùng số ước chung lớn nhất bằng 36', 'M', NULL, 'MH001', '2', N'36', N'60', N'48', N'72', 'A'),
(27, N'Câu 7: Tính tích phân ∫(x² + 2x)dx từ 0 đến 2', 'M', NULL, 'MH001', '3', N'8', N'10', N'12', N'14', 'C'),
(28, N'Câu 8: Tìm phần tử lớn nhất trong dãy số 2, 5, 7, 9, 12, 15, 20', 'M', NULL, 'MH001', '2', N'15', N'20', N'12', N'9', 'B'),
(29, N'Câu 9: Giải bất phương trình: log₂(x - 2) < 3', 'M', NULL, 'MH001', '2', N'x > 10', N'x > 8', N'x > 6', N'x > 4', 'D'),
(30, N'Câu 10: Tính diện tích hình cầu có bán kính 5', 'M', NULL, 'MH001', '3', N'100π', N'75π', N'50π', N'25π', 'A');

-- Thêm 30 câu hỏi mẫu về môn Văn (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(31, N'Bài thơ "Tràng Giang" là sáng tác của ai?', 'TN', NULL, 'MH002', 'E', N'Bạch Công Khanh', N'Trần Tế Xương', N'Hồ Xuân Hương', N'Nguyễn Du', 'C'),
(32, N'Tác phẩm "Chí Phèo" của tác giả nào?', 'TN', NULL, 'MH002', 'E', N'Trần Hữu Tri', N'Nam Cao', N'Nguyễn Hồng', N'Nam Cao', 'D'),
(33, N'Tragedy là thể loại văn học có đặc điểm gì?', 'TN', NULL, 'MH002', 'E', N'Trung thực', N'Bất hủ', N'Trinh thám', N'Bi kịch', 'D'),
(34, N'Tác phẩm "Số đỏ" của tác giả nào?', 'TN', NULL, 'MH002', 'E', N'Nguyễn Du', N'Hồ Xuân Hương', N'Nam Cao', N'Vũ Trọng Phụng', 'D'),
(35, N'Ý nghĩa của câu "Hồn nhiên như một đóa hoa sen"', 'TN', NULL, 'MH002', 'E', N'Không trang điểm', N'Đẹp tự nhiên', N'Xấu xí', N'Đầy cảm xúc', 'B'),
(36, N'Đoạn trích "Con người thường quá đỗi vội vã, đưa ra những quyết định quan trọng chỉ trong nháy mắt" thuộc tác phẩm nào?', 'TN', NULL, 'MH002', 'E', N'Chí Phèo', N'Tráng Giang', N'Số Đỏ', N'Chuyện Xưa', 'A'),
(37, N'Tác phẩm "Chinh phụ ngâm" của ai?', 'TN', NULL, 'MH002', 'E', N'Hồ Xuân Hương', N'Trần Tế Xương', N'Bạch Công Khanh', N'Nguyễn Du', 'B'),
(38, N'Tác giả của bài thơ "Em ơi Hà Nội phố" là ai?', 'TN', NULL, 'MH002', 'E', N'Huy Cận', N'Trần Tế Xương', N'Nguyễn Khuyến', N'Xuân Diệu', 'D'),
(39, N'Đoạn trích "Hai mươi năm trước, tôi không muốn đứa con nào chết" là của tác phẩm nào?', 'TN', NULL, 'MH002', 'E', N'Số Đỏ', N'Chí Phèo', N'Chuyện Xưa', N'Tráng Giang', 'A'),
(40, N'Ý nghĩa của biểu tượng hình ảnh hoa sen trong văn học?', 'TN', NULL, 'MH002', 'E', N'Không trang điểm', N'Đẹp tự nhiên', N'Xấu xí', N'Đầy cảm xúc', 'B'),
(41, N'Câu 1: Theo bạn, tác phẩm văn học nào đã có ảnh hưởng lớn đối với văn học Việt Nam thế kỷ XX?', 'TN', NULL, 'MH002', 'A', N'Tiếng Gọi Của Sóng', N'Tiểu Thuyết Một Góc Nhìn', N'Lão Hạc', N'Chiếc Lá Cuối Cùng', 'B'),
(42, N'Câu 2: Tác phẩm "Truyện Kiều" do ai sáng tác?', 'TN', NULL, 'MH002', 'A', N'Nguyễn Du', N'Tố Hữu', N'Xuân Diệu', N'Trần Đăng Khoa', 'A'),
(43, N'Câu 3: Trong "Truyện Kiều", Kieu có mấy lần phải đối diện với nguy cơ phản bội tình yêu?', 'TN', NULL, 'MH002', 'B', N'1 lần', N'2 lần', N'3 lần', N'Không lần nào', 'C'),
(44, N'Câu 4: Tác phẩm "Tố Tâm" thuộc thể loại văn học nào?', 'TN', NULL, 'MH002', 'B', N'Tragedy', N'Trinh Thám', N'Trinh Thám Tâm Lý', N'Truyện Ngắn', 'D'),
(45, N'Câu 5: Ai là tác giả của tác phẩm "Chí Phèo"?', 'TN', NULL, 'MH002', 'A', N'Nguyễn Du', N'Tố Hữu', N'Nam Cao', N'Nam Phong', 'C'),
(46, N'Câu 6: Tác phẩm "Số Đỏ" của nhà văn nào?', 'TN', NULL, 'MH002', 'A', N'Nam Cao', N'Nguyễn Du', N'Ngô Tất Tố', N'Vũ Trọng Phụng', 'D'),
(47, N'Câu 7: Nội dung chính của tác phẩm "Dế Mèn Phiêu Lưu Ký" là gì?', 'TN', NULL, 'MH002', 'B', N'Trận chiến của dế với chuột', N'Tìm kiếm bạn bè', N'Hành trình phiêu lưu của dế mèn', N'Chinh phục những khó khăn', 'C'),
(48, N'Câu 8: Tác phẩm "Chí Phèo" là tác phẩm văn học thuộc thời kỳ nào trong văn học Việt Nam?', 'TN', NULL, 'MH002', 'B', N'Phong cách cũ', N'Modernism', N'Hiện đại', N'Phong cách mới', 'A'),
(49, N'Câu 9: Tác phẩm "Chí Phèo" của Nam Cao đã phê phán những điều gì trong xã hội?', 'TN', NULL, 'MH002', 'B', N'Xã hội hiện tại', N'Nạn phân biệt giai cấp', N'Tình trạng nghèo đói', N'Tất cả đều đúng', 'D'),
(50, N'Câu 10: Tác phẩm "Tố Tâm" của tác giả Nam Cao được xây dựng dựa trên hình ảnh của người nông dân trong thời kỳ nào?', 'TN', NULL, 'MH002', 'B', N'Thời kỳ phong kiến', N'Thời kỳ Pháp thuộc', N'Thời kỳ cận đại', N'Thời kỳ cách mạng', 'C'),
(51, N'Câu 1: Theo em, tác phẩm "Chí Phèo" của Nam Cao thể hiện những giá trị gì về con người và xã hội?', 'TN', NULL, 'MH002', 'A', N'Thể hiện sự đau khổ và nhân văn trong cuộc sống.', N'Phản ánh sự bất công và tầng lớp xã hội', N'Kể về tình bạn và lòng nhân ái.', N'Mô tả về sự đấu tranh cho ý chí sống.', 'B'),
(52, N'Câu 2: Tác phẩm "Truyện Kiều" của Nguyễn Du thuộc thể loại nào và có những đặc điểm nào nổi bật?', 'TN', NULL, 'MH002', 'A', N'Tragedy, sử dụng thơ lục bát và miêu tả cảnh sắc.', N'Trinh thám, phân tích tâm lý nhân vật chính.', N'Truyện cổ tích, sử dụng ngôn ngữ đơn giản dễ hiểu.', N'Trinh thám, sử dụng ngôn ngữ hài hước.', 'A'),
(53, N'Câu 3: Tác phẩm "Tố Tâm" của Hoàng Ngọc Phách thuộc thể loại gì và chủ đề chính là gì?', 'TN', NULL, 'MH002', 'A', N'Tragedy, mô tả về cuộc đời của một người phụ nữ.', N'Kỳ án, về một vụ án mạng ly kỳ.', N'Trinh thám, khám phá về tâm lý con người.', N'Tragedy, mô tả về cuộc sống của người dân nghèo.', 'A'),
(54, N'Câu 4: Tác phẩm "Số đỏ" của Vũ Trọng Phụng chủ yếu phản ánh vấn đề gì trong xã hội Việt Nam thời kỳ đó?', 'TN', NULL, 'MH002', 'A', N'Thấp kém về đạo đức và thái độ của giới trí thức.', N'Chủ nghĩa cá nhân và sự nghiệp.', N'Bài trí về văn hóa và lối sống hiện đại.', N'Quyền lực và tham nhũng trong xã hội.', 'D'),
(55, N'Câu 5: Tác phẩm "Dế mèn phiêu lưu ký" của Tô Hoài mang thông điệp gì đối với trẻ em?', 'TN', NULL, 'MH002', 'A', N'Bài học về tình bạn và lòng kiên nhẫn.', N'Kích thích sự sáng tạo và hiếu kỳ.', N'Khuyến khích sự đoàn kết và hợp tác.', N'Giáo dục ý thức bảo vệ môi trường.', 'B'),
(56, N'Câu 6: Tác phẩm "Chinh phụ ngâm" của Đoàn Thị Điểm chủ yếu nói về điều gì?', 'TN', NULL, 'MH002', 'A', N'Tình yêu và sự kiên trì của người phụ nữ.', N'Chiến tranh và bảo vệ tổ quốc.', N'Những khó khăn trong cuộc sống thường nhật.', N'Cuộc sống văn hóa và xã hội thời xưa.', 'A'),
(57, N'Câu 7: Tác phẩm "Truyện ngắn Nam Cao" thường thể hiện những nét đặc trưng nào của cuộc sống miền quê Việt Nam?', 'TN', NULL, 'MH002', 'A', N'Cuộc sống yên bình và hạnh phúc của người dân quê.', N'Những khó khăn, bất công và khốn khổ.', N'Cuộc sống hoang dã và hiểm nguy của người dân.', N'Cuộc sống hối hả và đầy căng thẳng.', 'B'),
(58, N'Câu 8: Theo em, tác phẩm "Nhà giả kim" của Paulo Coelho có thông điệp gì về cuộc sống và ước mơ?', 'TN', NULL, 'MH002', 'A', N'Thể hiện sự quan trọng của hiện thực và sự kiên nhẫn.', N'Phản ánh sự giàu có và thịnh vượng.', N'Thể hiện quy luật tự nhiên và trách nhiệm cá nhân.', N'Thể hiện sự kiên trì và lòng dũng cảm trước thách thức.', 'D'),
(59, N'Câu 9: Tác phẩm "Tắt đèn" của Ngô Tất Tố chủ yếu phản ánh vấn đề gì trong xã hội thời đó?', 'TN', NULL, 'MH002', 'A', N'Bất công và sự chia rẽ trong tình yêu.', N'Thể hiện sự giàu có và thịnh vượng.', N'Khốn khổ và cuộc sống của người nghèo.', N'Chủ nghĩa cá nhân và sự nghiệp.', 'C'),
(60, N'Câu 10: Tác phẩm "Người giàu có nhất thế giới" của Đale Carnegie có ý nghĩa gì trong việc phát triển bản thân và xã hội?', 'TN', NULL, 'MH002', 'A', N'Khuyến khích sự sáng tạo và hiếu kỳ.', N'Đề cao quyền lực và vị thế xã hội.', N'Thể hiện sự quan trọng của trí tuệ và kiến thức.', N'Chia sẻ cách thức để thành công và hạnh phúc.', 'D');

-- Thêm 30 câu hỏi mẫu về môn LS (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(61, N'Câu 61: Tại sao việc học lịch sử quan trọng đối với việc hiểu về xã hội hiện tại?', 'TN', NULL, 'MH003', 'A', N'Giúp hiểu về nguồn gốc và phát triển của xã hội.', N'Không liên quan, lịch sử chỉ là quá khứ.', N'Chỉ giúp hiểu về quá khứ, không ảnh hưởng đến hiện tại.', N'Tác động trực tiếp đến việc xây dựng tương lai.', 'A'),
(62, N'Câu 62: Thế nào là Cách mạng công nghiệp? Đây là sự kiện quan trọng như thế nào trong lịch sử?', 'TN', NULL, 'MH003', 'A', N'Cách mạng công nghiệp là giai đoạn chuyển đổi từ sản xuất thủ công sang sản xuất công nghiệp.', N'Cách mạng công nghiệp không có ý nghĩa đặc biệt trong lịch sử.', N'Đây chỉ là một sự kiện nhỏ trong lịch sử.', N'Là sự kiện quan trọng, đánh dấu sự phát triển to lớn trong lịch sử nhân loại.', 'D'),
(63, N'Câu 63: Đặc điểm nào là nổi bật của thời kỳ Trung cổ ở Châu Âu?', 'TN', NULL, 'MH003', 'A', N'Phong kiến hình thành mạnh mẽ, tôn quý lớp quý tộc.', N'Thời kỳ Trung cổ không có điểm gì nổi bật.', N'Không có sự thay đổi đáng kể nào trong thời kỳ này.', N'Quân chủng hình thành mạnh mẽ và phong kiến suy vong.', 'A'),
(64, N'Câu 64: Tại sao cuộc Cách mạng Pháp (1789) quan trọng trong lịch sử thế giới?', 'TN', NULL, 'MH003', 'A', N'Đây chỉ là một sự kiện nhỏ trong lịch sử.', N'Không có ý nghĩa gì đặc biệt trong lịch sử thế giới.', N'Là sự kiện quan trọng, đánh dấu sự thay đổi to lớn trong xã hội và chính trị thế giới.', N'Cách mạng Pháp không ảnh hưởng đến lịch sử thế giới.', 'C'),
(65, N'Câu 65: Nêu ý nghĩa của Chiến tranh thế giới thứ nhất trong lịch sử nhân loại.', 'TN', NULL, 'MH003', 'A', N'Là sự kiện không quan trọng trong lịch sử.', N'Không có ý nghĩa gì đặc biệt trong lịch sử thế giới.', N'Là sự kiện quan trọng, đánh dấu sự thay đổi to lớn trong cấu trúc quốc tế và xã hội.', N'Chiến tranh thế giới thứ nhất không có tác động gì đến lịch sử nhân loại.', 'C'),
(66, N'Câu 66: Vì sao Cách mạng tháng Mười Nga lại quan trọng trong lịch sử thế giới?', 'TN', NULL, 'MH003', 'A', N'Cách mạng này không quan trọng trong lịch sử.', N'Chỉ là một sự kiện nhỏ không ảnh hưởng đến lịch sử thế giới.', N'Là sự kiện quan trọng, đánh dấu sự thay đổi lớn trong hệ thống chính trị thế giới.', N'Không có tác động gì đáng kể đến lịch sử thế giới.', 'C'),
(67, N'Câu 67: Ý nghĩa của Cách mạng Việt Nam (1945) trong lịch sử dân tộc?', 'TN', NULL, 'MH003', 'A', N'Không có ý nghĩa gì đặc biệt trong lịch sử dân tộc.', N'Cách mạng này không có tác động gì đến lịch sử dân tộc.', N'Là sự kiện quan trọng, đánh dấu sự thay đổi to lớn trong lịch sử và tình hình chính trị Việt Nam.', N'Chỉ là một sự kiện nhỏ không ảnh hưởng đến lịch sử dân tộc.', 'C'),
(68, N'Câu 68: Tại sao nền văn minh Ai Cập cổ đại lại được coi là một trong những nền văn minh vĩ đại nhất trong lịch sử nhân loại?', 'TN', NULL, 'MH003', 'A', N'Không có điểm gì đặc biệt trong nền văn minh Ai Cập cổ đại.', N'Nền văn minh này không ảnh hưởng gì trong lịch sử nhân loại.', N'Là nền văn minh phát triển mạnh mẽ với đóng góp lớn cho ngành khoa học và văn hóa nhân loại.', N'Chỉ là một nền văn minh thông thường không có gì đặc biệt.', 'C'),
(69, N'Câu 69: Ý nghĩa của Cuộc Cách mạng Xanh (1968) trong lịch sử Việt Nam?', 'TN', NULL, 'MH003', 'A', N'Cách mạng này không có tác động gì đến lịch sử Việt Nam.', N'Không có ý nghĩa gì đặc biệt trong lịch sử Việt Nam.', N'Là sự kiện quan trọng, góp phần quyết định vào cuộc chiến tranh chống Mỹ.', N'Chỉ là một sự kiện nhỏ không ảnh hưởng đến lịch sử Việt Nam.', 'C'),
(70, N'Câu 70: Tại sao việc nắm vững kiến thức lịch sử là cần thiết cho mọi người?', 'TN', NULL, 'MH003', 'A', N'Lịch sử không quan trọng và không cần thiết cho mọi người.', N'Việc nắm vững kiến thức lịch sử giúp mọi người hiểu về quá khứ và tương lai.', N'Chỉ cần biết một số sự kiện lịch sử quan trọng, không cần phải nắm vững kiến thức lịch sử.', N'Lịch sử chỉ là một môn học không cần thiết.', 'B'),
(71, N'Câu 1: Định hình lịch sử nào góp phần hình thành nền văn minh cổ đại ở Ai Cập?', 'TN', NULL, 'MH003', 'A', N'Lịch sử Babilon', N'Lịch sử Hùng Vương', N'Lịch sử Thượng Miên', N'Lịch sử Nữ hoàng Hatshepsut', 'D'),
(72, N'Câu 2: Trận chiến nào được xem là sự kiện quyết định quân sự lớn nhất trong lịch sử Hy Lạp cổ đại?', 'TN', NULL, 'MH003', 'A', N'Trận chiến Marathon', N'Trận chiến Salamis', N'Trận chiến Thermopylae', N'Trận chiến Chaeronea', 'B'),
(73, N'Câu 3: Vị vua nào được xem là người sáng lập ra Đế quốc La Mã và làm thay đổi lịch sử thế giới?', 'TN', NULL, 'MH003', 'A', N'Julius Caesar', N'Augustus', N'Constantine', N'Romulus Augustulus', 'B'),
(74, N'Câu 4: Đâu là sự kiện đánh dấu sự chia cắt nền văn minh Hy Lạp thành hai phần, La Mã Đông và La Mã Tây?', 'TN', NULL, 'MH003', 'A', N'Cải cách đạo luật Solon', N'Sự kiện Phân chia Đế quốc La Mã', N'Tiểu bang La Mã trở thành nước cộng hòa', N'Tiểu bang La Mã bị xâm chiếm bởi Macedonia', 'B'),
(75, N'Câu 5: Ai là người đã đưa ra học thuyết về "Ba quyền lực" (trích trong cuốn sách "L`Esprit des lois")?', 'TN', NULL, 'MH003', 'A', N'John Locke', N'Charles de Montesquieu', N'Jean-Jacques Rousseau', N'Voltaire', 'B'),
(76, N'Câu 6: Tác giả nào đã viết cuốn sách "Lịch sử Bắc Âu" (History of the Northmen)?', 'TN', NULL, 'MH003', 'A', N'Adam of Bremen', N'Snorri Sturluson', N'Tác giả không rõ', N'Bede', 'A'),
(77, N'Câu 7: Tác giả nào viết cuốn sách "Lịch sử Đế chế La Mã" (The History of the Decline and Fall of the Roman Empire)?', 'TN', NULL, 'MH003', 'A', N'Edward Gibbon', N'Herodotus', N'Thucydides', N'Tác giả không rõ', 'A'),
(78, N'Câu 8: Sự kiện nào đánh dấu sự chấm dứt của Thời kỳ Trung cổ và bắt đầu Thời kỳ Phục hưng (Renaissance)?', 'TN', NULL, 'MH003', 'A', N'Cuộc Cải cách Tôn giáo', N'Cuộc Thập tự chinh thứ nhất', N'Cuộc Triều đại Bắc Âu', N'Cuộc Chinh phục Constantinople', 'D'),
(79, N'Câu 9: Ai là người đã viết cuốn sách "Cuộc cách mạng nông nghiệp" (The Agricultural Revolution)?', 'TN', NULL, 'MH003', 'A', N'Karl Marx', N'Adam Smith', N'James Watt', N'Tác giả không rõ', 'B'),
(80, N'Câu 10: Sự kiện nào đánh dấu sự kết thúc của Thế chiến thứ nhất?', 'TN', NULL, 'MH003', 'A', N'Hiệp ước Versailles', N'Hiệp ước Brest-Litovsk', N'Hiệp ước Trianon', N'Hiệp ước Saint-Germain', 'A'),
(81, N'Câu 81: Bạn hãy mô tả ngắn gọn về Cách mạng công nghiệp thứ nhất và tác động của nó đối với thế giới?', 'TN', NULL, 'MH003', 'A', N'Là sự chuyển đổi từ sản xuất thủ công sang sản xuất công nghiệp với việc áp dụng máy móc và công nghệ.', N'Gây ra sự thay đổi về kinh tế, xã hội và văn hóa, tạo ra nền tảng cho sự phát triển toàn cầu.', N'Là giai đoạn phát triển của nền kinh tế thị trường tự do.', N'Tác động mạnh mẽ đối với việc tăng cường quan hệ quốc tế.', 'B'),
(82, N'Câu 82: Tại sao Cách mạng công nghiệp thứ hai được xem là quan trọng và tác động như thế nào đến thế giới?', 'TN', NULL, 'MH003', 'A', N'Tăng cường sự tự động hóa và sự phát triển của công nghệ thông tin.', N'Gây ra sự thay đổi lớn về công nghiệp, nền kinh tế và văn hóa.', N'Làm gia tăng sự chuyển đổi từ nền kinh tế nông nghiệp sang công nghiệp.', N'Tạo ra sự chia rẽ lớn trong xã hội.', 'B'),
(83, N'Câu 83: Lịch sử thế giới hiện đại phát triển từ sự kiện nào và có những đặc điểm nổi bật như thế nào?', 'TN', NULL, 'MH003', 'A', N'Phát triển từ Cách mạng công nghiệp thứ hai với sự gia tăng về công nghiệp, công nghệ và toàn cầu hóa.', N'Thành công về mặt kinh tế và phát triển bền vững.', N'Tạo ra sự đa dạng văn hóa và chính trị trên toàn thế giới.', N'Làm gia tăng sự đa dạng về chủ nghĩa xã hội.', 'A'),
(84, N'Câu 84: Sự kiện Lịch sử thế giới đặc biệt nào đã dẫn đến Cuộc Cách mạng Công nghiệp thứ nhất?', 'TN', NULL, 'MH003', 'A', N'Chiến tranh thế giới thứ nhất với sự xung đột giữa các quốc gia lớn trên thế giới.', N'Sự đối đầu giữa các tầng lớp trong xã hội.', N'Thành công về mặt kinh tế và phát triển bền vững.', N'Làm gia tăng sự chia rẽ lớn trong xã hội.', 'A'),
(85, N'Câu 85: Tác động của Chiến tranh thế giới thứ nhất đến thế giới như thế nào và những hậu quả chính là gì?', 'TN', NULL, 'MH003', 'A', N'Gây ra sự chia rẽ lớn và sự thay đổi về địa lý quốc gia trên thế giới.', N'Thành công về mặt kinh tế và phát triển bền vững.', N'Tạo ra sự đa dạng văn hóa và chính trị trên toàn thế giới.', N'Làm gia tăng sự đa dạng về chủ nghĩa xã hội.', 'A'),
(86, N'Câu 86: Tại sao Cách mạng công nghiệp thứ hai được coi là bước tiến quan trọng trong lịch sử?', 'TN', NULL, 'MH003', 'A', N'Tăng cường sự tự động hóa và sự phát triển của công nghệ thông tin.', N'Gây ra sự thay đổi lớn về công nghiệp, nền kinh tế và văn hóa.', N'Làm gia tăng sự chuyển đổi từ nền kinh tế nông nghiệp sang công nghiệp.', N'Tạo ra sự chia rẽ lớn trong xã hội.', 'B'),
(87, N'Câu 87: Lịch sử thế giới hiện đại phát triển từ sự kiện nào và có những đặc điểm nổi bật như thế nào?', 'TN', NULL, 'MH003', 'A', N'Phát triển từ Cách mạng công nghiệp thứ hai với sự gia tăng về công nghiệp, công nghệ và toàn cầu hóa.', N'Thành công về mặt kinh tế và phát triển bền vững.', N'Tạo ra sự đa dạng văn hóa và chính trị trên toàn thế giới.', N'Làm gia tăng sự đa dạng về chủ nghĩa xã hội.', 'A'),
(88, N'Câu 88: Sự kiện Lịch sử thế giới đặc biệt nào đã dẫn đến Cuộc Cách mạng Công nghiệp thứ nhất?', 'TN', NULL, 'MH003', 'A', N'Chiến tranh thế giới thứ nhất với sự xung đột giữa các quốc gia lớn trên thế giới.', N'Sự đối đầu giữa các tầng lớp trong xã hội.', N'Thành công về mặt kinh tế và phát triển bền vững.', N'Làm gia tăng sự chia rẽ lớn trong xã hội.', 'A'),
(89, N'Câu 89: Tác động của Chiến tranh thế giới thứ nhất đến thế giới như thế nào và những hậu quả chính là gì?', 'TN', NULL, 'MH003', 'A', N'Gây ra sự chia rẽ lớn và sự thay đổi về địa lý quốc gia trên thế giới.', N'Thành công về mặt kinh tế và phát triển bền vững.', N'Tạo ra sự đa dạng văn hóa và chính trị trên toàn thế giới.', N'Làm gia tăng sự đa dạng về chủ nghĩa xã hội.', 'A'),
(90, N'Câu 90: Tại sao Cách mạng công nghiệp thứ hai được coi là bước tiến quan trọng trong lịch sử?', 'TN', NULL, 'MH003', 'A', N'Tăng cường sự tự động hóa và sự phát triển của công nghệ thông tin.', N'Gây ra sự thay đổi lớn về công nghiệp, nền kinh tế và văn hóa.', N'Làm gia tăng sự chuyển đổi từ nền kinh tế nông nghiệp sang công nghiệp.', N'Tạo ra sự chia rẽ lớn trong xã hội.', 'B');

-- Thêm 10 câu hỏi mẫu về môn ĐL (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(91, N'Câu 91: Biểu đồ nào thường được sử dụng để biểu diễn sự phân bố dân số trên thế giới? Hãy mô tả ngắn gọn về biểu đồ đó và những thông tin quan trọng mà nó cung cấp.', 'TN', NULL, 'MH004', 'A', N'Biểu đồ cột, biểu thị tỷ lệ dân số theo từng khu vực địa lý.', N'Biểu đồ đường, thể hiện sự biến đổi của dân số qua các năm.', N'Biểu đồ tròn, minh họa phần trăm dân số theo nhóm tuổi.', N'Biểu đồ pie chart, cho thấy sự phân bố dân số theo các lục địa và quốc gia.', 'D'),
(92, N'Câu 92: Địa hình đồng bằng có những đặc điểm chính như thế nào và tại sao chúng phát triển thành những khu vực trọng điểm? Hãy chỉ ra một số ví dụ về địa hình đồng bằng nổi tiếng trên thế giới.', 'TN', NULL, 'MH004', 'A', N'Địa hình phẳng, có độ cao thấp, có sự tích tụ của đất vàng.', N'Phát triển do sự tích tụ của đất đai phong phú từ sông lớn.', N'Địa hình nhiều đồi núi, tạo điều kiện thuận lợi cho nông nghiệp.', N'Xuất hiện nhiều hệ thống sông ngòi và vùng đất màu mỡ.', 'B'),
(93, N'Câu 93: Hiện tượng nào gây ra sự biến đổi về khí hậu trên Trái Đất và làm thay đổi môi trường sống của con người? Hãy đề xuất một số biện pháp giải quyết cho vấn đề này.', 'TN', NULL, 'MH004', 'A', N'Biến đổi khí hậu do hoạt động công nghiệp, giao thông và nhu cầu năng lượng.', N'Tăng cường sử dụng nguồn năng lượng sạch như điện mặt trời và gió.', N'Khí hậu biến đổi gây ra sự suy giảm đáng kể về nguồn nước.', N'Giải pháp có thể bao gồm việc giảm khí thải và thay đổi lối sống tiết kiệm năng lượng.', 'D'),
(94, N'Câu 94: Sự nổi tiếng của hệ thống dãy núi Himalaya không chỉ là vấn đề địa lý mà còn có ý nghĩa như thế nào đối với con người và môi trường sống của họ?', 'TN', NULL, 'MH004', 'A', N'Đây là dãy núi cao nhất thế giới, có vai trò quan trọng trong việc kiểm soát khí hậu.', N'Tạo ra điều kiện thuận lợi cho du lịch leo núi và nghiên cứu khoa học.', N'Gây ra hiện tượng biến đổi khí hậu đặc biệt trên toàn cầu.', N'Đây là nơi có nhiều nguồn tài nguyên tự nhiên quý báu và quan trọng.', 'A'),
(95, N'Câu 95: Hiện tượng nào gây ra sự biến đổi về khí hậu trên Trái Đất và làm thay đổi môi trường sống của con người? Hãy đề xuất một số biện pháp giải quyết cho vấn đề này.', 'TN', NULL, 'MH004', 'A', N'Biến đổi khí hậu do hoạt động công nghiệp, giao thông và nhu cầu năng lượng.', N'Tăng cường sử dụng nguồn năng lượng sạch như điện mặt trời và gió.', N'Khí hậu biến đổi gây ra sự suy giảm đáng kể về nguồn nước.', N'Giải pháp có thể bao gồm việc giảm khí thải và thay đổi lối sống tiết kiệm năng lượng.', 'D'),
(96, N'Câu 96: Sự nổi tiếng của hệ thống dãy núi Himalaya không chỉ là vấn đề địa lý mà còn có ý nghĩa như thế nào đối với con người và môi trường sống của họ?', 'TN', NULL, 'MH004', 'A', N'Đây là dãy núi cao nhất thế giới, có vai trò quan trọng trong việc kiểm soát khí hậu.', N'Tạo ra điều kiện thuận lợi cho du lịch leo núi và nghiên cứu khoa học.', N'Gây ra hiện tượng biến đổi khí hậu đặc biệt trên toàn cầu.', N'Đây là nơi có nhiều nguồn tài nguyên tự nhiên quý báu và quan trọng.', 'A'),
(97, N'Câu 97: Dãy núi Rocky Mountains ở Bắc Mỹ có ý nghĩa như thế nào trong việc ảnh hưởng đến môi trường sống và nguồn tài nguyên của khu vực này?', 'TN', NULL, 'MH004', 'A', N'Đây là dãy núi có địa hình phức tạp, tạo ra nhiều điều kiện thuận lợi cho việc khai thác khoáng sản.', N'Tạo ra một rào cản tự nhiên chống lại sự lan truyền của các loại thảm họa tự nhiên.', N'Gây ra hiện tượng biến đổi khí hậu đặc biệt trên toàn cầu.', N'Cung cấp nguồn nước quý báu cho vùng đất xung quanh và hỗ trợ cho sự phát triển nông nghiệp.', 'D'),
(98, N'Câu 98: Dãy núi Andes ở Nam Mỹ có ảnh hưởng như thế nào đối với môi trường sống và nguồn tài nguyên của khu vực này?', 'TN', NULL, 'MH004', 'A', N'Đây là dãy núi kéo dài, tạo ra điều kiện thuận lợi cho việc phát triển du lịch và thể dục thể thao.', N'Tạo ra một rào cản tự nhiên chống lại sự lan truyền của các loại thảm họa tự nhiên.', N'Gây ra hiện tượng biến đổi khí hậu đặc biệt trên toàn cầu.', N'Cung cấp nguồn nước quý báu cho vùng đất xung quanh và hỗ trợ cho sự phát triển nông nghiệp.', 'D'),
(99, N'Câu 99: Tại sao sông Amazon lại quan trọng và có tác động như thế nào đối với môi trường sống và con người tại khu vực Nam Mỹ?', 'TN', NULL, 'MH004', 'A', N'Sông Amazon có dòng chảy mạnh mẽ, tạo điều kiện thuận lợi cho giao thông và vận chuyển hàng hóa.', N'Là nguồn nước quý báu cho vùng đất xung quanh, hỗ trợ cho sự phát triển nông nghiệp và đời sống.', N'Gây ra hiện tượng biến đổi khí hậu đặc biệt trên toàn cầu.', N'Tạo ra một rào cản tự nhiên chống lại sự lan truyền của các loại thảm họa tự nhiên.', 'B'),
(100, N'Câu 100: Địa hình núi cao và vùng sa mạc Sahara có tác động như thế nào đến môi trường sống và nguồn tài nguyên của khu vực đó?', 'TN', NULL, 'MH004', 'A', N'Địa hình núi cao tạo ra điều kiện thuận lợi cho việc phát triển du lịch và thể dục thể thao.', N'Sa mạc Sahara có nguồn nước cạn kiệt, gây khó khăn cho đời sống và phát triển của người dân.', N'Gây ra hiện tượng biến đổi khí hậu đặc biệt trên toàn cầu.', N'Tạo ra một rào cản tự nhiên chống lại sự lan truyền của các loại thảm họa tự nhiên.', 'B');

-- Thêm 10 câu hỏi mẫu về môn Tiếng Anh (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(101, N'Câu 101: What is the capital city of Australia?', 'TN', NULL, 'MH005', 'A', N'Sydney', N'Canberra', N'Melbourne', N'Brisbane', 'B'),
(102, N'Câu 102: Who wrote the famous play "Romeo and Juliet"?', 'TN', NULL, 'MH005', 'A', N'William Wordsworth', N'Charles Dickens', N'William Shakespeare', N'Jane Austen', 'C'),
(103, N'Câu 103: Which tense is used to describe an action that will happen in the future?', 'TN', NULL, 'MH005', 'A', N'Past tense', N'Present tense', N'Future tense', N'Continuous tense', 'C'),
(104, N'Câu 104: What is the comparative form of "good"?', 'TN', NULL, 'MH005', 'A', N'Better', N'Gooder', N'More good', N'Best', 'A'),
(105, N'Câu 105: Who invented the telephone?', 'TN', NULL, 'MH005', 'A', N'Alexander Graham Bell', N'Thomas Edison', N'Albert Einstein', N'Isaac Newton', 'A'),
(106, N'Câu 106: Which word means the opposite of "strong"?', 'TN', NULL, 'MH005', 'A', N'Weak', N'Powerful', N'Mighty', N'Sturdy', 'A'),
(107, N'Câu 107: "To put something off" means to...', 'TN', NULL, 'MH005', 'A', N'Delay', N'Cancel', N'Start', N'Continue', 'A'),
(108, N'Câu 108: Who is credited with painting the Mona Lisa?', 'TN', NULL, 'MH005', 'A', N'Leonardo da Vinci', N'Vincent van Gogh', N'Pablo Picasso', N'Michelangelo', 'A'),
(109, N'Câu 109: What is the plural form of "child"?', 'TN', NULL, 'MH005', 'A', N'Childs', N'Childrens', N'Childs', N'Children', 'D'),
(110, N'Câu 110: What is the longest river in the world?', 'TN', NULL, 'MH005', 'A', N'The Amazon River', N'The Nile River', N'The Mississippi River', N'The Yangtze River', 'B');

-- Thêm 10 câu hỏi mẫu về môn Hóa Học (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(111, N'Câu 111: Nguyên tử Hidro có cấu tạo như thế nào và số proton, neutron, electron của nó là bao nhiêu?', 'TN', NULL, 'MH006', 'A', N'Hidro có cấu tạo từ 1 proton, 1 neutron, và 1 electron.', N'Hidro có cấu tạo từ 1 proton, 0 neutron, và 1 electron.', N'Hidro có cấu tạo từ 0 proton, 1 neutron, và 0 electron.', N'Hidro có cấu tạo từ 1 proton, 0 neutron, và 2 electron.', 'A'),
(112, N'Câu 112: Tại sao năng lượng liên kết của liên kết ion lại cao hơn so với liên kết cộng hóa trị?', 'TN', NULL, 'MH006', 'A', N'Do liên kết ion có độ bền hơn và tạo ra lưới tinh thể chặt chẽ hơn.', N'Trong liên kết ion, các electron chia sẻ cộng hóa trị gần nhau hơn.', N'Do liên kết cộng hóa trị chứa các liên kết phân cực.', N'Liên kết ion có áp dụng năng lượng cao hơn.', 'A'),
(113, N'Câu 113: Tại sao axit clohidric (HCl) được coi là một axit mạnh?', 'TN', NULL, 'MH006', 'A', N'Vì HCl hoàn toàn phân li trong dung dịch nước để tạo ra H+ và Cl-.', N'Tính axit của HCl phụ thuộc vào nồng độ dung dịch.', N'HCl có độ bền cao khi tiếp xúc với nước.', N'HCl không thể phản ứng với các chất bazơ.', 'A'),
(114, N'Câu 114: Sự phân cực trong các phân tử H2O dẫn đến hiện tượng gì trong nước?', 'TN', NULL, 'MH006', 'A', N'Lực liên kết giữa các phân tử nước tăng cường, tạo ra sức căng bề mặt.', N'Nước trở thành chất dẫn điện kém hơn.', N'Nước trở nên ít phân cực hơn.', N'Điện tích của nước giảm.', 'A'),
(115, N'Câu 115: Trạng thái lỏng của một chất phụ thuộc vào những yếu tố nào?', 'TN', NULL, 'MH006', 'A', N'Sự phân cực và lực tương tác giữa các phân tử.', N'Nhiệt độ và áp suất.', N'Khối lượng phân tử của chất đó.', N'Điện tích của nguyên tử trong chất.', 'B'),
(116, N'Câu 116: Trạng thái plasma xuất hiện trong điều kiện nào và có những đặc điểm gì?', 'TN', NULL, 'MH006', 'A', N'Xuất hiện ở nhiệt độ rất cao và áp suất thấp, các electron và proton không kết hợp lại với nhau.', N'Xuất hiện ở nhiệt độ rất cao và áp suất cao, các electron không liên kết với nhân nguyên tử.', N'Xuất hiện ở nhiệt độ thấp và áp suất cao, các electron di chuyển tự do.', N'Xuất hiện ở nhiệt độ thấp và áp suất thấp, các electron không kết hợp với nhân nguyên tử.', 'A'),
(117, N'Câu 117: Đặc điểm nào của vật chất giúp xác định tính chất hoá học của nó?', 'TN', NULL, 'MH006', 'A', N'Số nguyên tử và cấu trúc phân tử.', N'Nhiệt độ và áp suất.', N'Điện tích của các nguyên tử trong phân tử.', N'Thể tích và khối lượng phân tử.', 'A'),
(118, N'Câu 118: Tại sao kim loại có tính dẫn điện tốt?', 'TN', NULL, 'MH006', 'A', N'Tính dẫn điện của kim loại xuất phát từ sự di chuyển tự do của electron trong lưới tinh thể kim loại.', N'Kim loại có nhiều electron hơn các nguyên tử khác.', N'Nguyên tử kim loại có điện tích dương cao.', N'Kim loại có khả năng nhận electron từ các chất khác.', 'A'),
(119, N'Câu 119: Tại sao một số nguyên tử có khả năng tạo ra ion dương hoặc ion âm?', 'TN', NULL, 'MH006', 'A', N'Vì một số nguyên tử có số electron lớn hơn hoặc nhỏ hơn điện tích hạt nhân của chúng.', N'Sự tương tác giữa các electron và proton trong nguyên tử.', N'Vì khối lượng nguyên tử tăng hoặc giảm đột ngột.', N'Tính chất hoá học của nguyên tử đó.', 'A'),
(120, N'Câu 120: Tại sao lực liên kết trong phân tử Cl2 mạnh hơn so với phân tử F2?', 'TN', NULL, 'MH006', 'A', N'Vì Cl có số proton và electron lớn hơn, tạo ra lực liên kết mạnh hơn.', N'Vì Cl có nguyên tử lớn hơn nên tạo ra lực liên kết mạnh hơn.', N'Lực liên kết phụ thuộc vào số lượng electron trong nguyên tử.', N'Lực liên kết phụ thuộc vào khối lượng nguyên tử của nguyên tố.', 'A');

-- Thêm 10 câu hỏi mẫu về môn Sinh Học (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(121, N'Câu 121: Sự khác biệt giữa tế bào động vật và tế bào thực vật là gì?', 'TN', NULL, 'MH007', 'A', N'Tế bào động vật có tường bao bên ngoài cứng, trong khi tế bào thực vật không có tường bao.', N'Tế bào thực vật có tường bao bên ngoài cứng, trong khi tế bào động vật không có tường bao.', N'Tế bào thực vật có hệ thống kênh khí, trong khi tế bào động vật không có.', N'Tế bào động vật có nhiều lõi nhân, trong khi tế bào thực vật có một lõi nhân.', 'A'),
(122, N'Câu 122: Hãy mô tả quá trình quang hợp trong tế bào thực vật.', 'TN', NULL, 'MH007', 'A', N'Là quá trình tạo ra năng lượng từ ánh sáng, nước và khí cacbonic để tổng hợp thành các hợp chất hữu cơ.', N'Là quá trình phát triển của tế bào thực vật dưới ánh sáng mặt trời.', N'Là quá trình tự sản xuất thức ăn cho tế bào thực vật.', N'Là quá trình sản xuất oxy cho không khí.', 'A'),
(123, N'Câu 123: Sự khác biệt giữa hệ hô hấp bị điều khiển và không điều khiển là gì?', 'TN', NULL, 'MH007', 'A', N'Hệ hô hấp bị điều khiển là hô hấp tự động, trong khi hệ hô hấp không điều khiển là hô hấp do ý thức.', N'Hệ hô hấp bị điều khiển là hô hấp do ý thức, trong khi hệ hô hấp không điều khiển là hô hấp tự động.', N'Hệ hô hấp bị điều khiển là hô hấp định kỳ, trong khi hệ hô hấp không điều khiển là hô hấp không định kỳ.', N'Hệ hô hấp bị điều khiển là hô hấp của động vật, trong khi hệ hô hấp không điều khiển là hô hấp của thực vật.', 'A'),
(124, N'Câu 124: Sự khác biệt giữa tế bào thực vật và tế bào động vật trong quá trình tiêu hóa là gì?', 'TN', NULL, 'MH007', 'A', N'Tế bào thực vật tiêu hóa bằng phản ứng hồi quy, trong khi tế bào động vật tiêu hóa bằng phản ứng trực tiếp.', N'Tế bào thực vật tiêu hóa bằng phản ứng trực tiếp, trong khi tế bào động vật tiêu hóa bằng phản ứng hồi quy.', N'Tế bào thực vật tiêu hóa bằng phản ứng dị ứng, trong khi tế bào động vật tiêu hóa bằng phản ứng hồi quy.', N'Tế bào thực vật tiêu hóa bằng phản ứng hòa tan, trong khi tế bào động vật tiêu hóa bằng phản ứng phân hủy.', 'A'),
(125, N'Câu 125: Mô tả ngắn gọn về chu trình Nitơ trong tự nhiên và vai trò của vi khuẩn trong chu trình này.', 'TN', NULL, 'MH007', 'A', N'Chu trình Nitơ là chu trình vòng tròn của việc chuyển đổi các hợp chất nitơ trong môi trường.', N'Vi khuẩn chủ yếu thực hiện quá trình nitơ hóa và nitrat hóa trong chu trình này.', N'Chu trình Nitơ là chu trình đơn giản của quá trình hấp thụ nitơ từ không khí.', N'Vi khuẩn không đóng vai trò quan trọng trong chu trình Nitơ.', 'B'),
(126, N'Câu 126: Sự khác biệt giữa tế bào thực vật và tế bào động vật trong quá trình trao đổi chất là gì?', 'TN', NULL, 'MH007', 'A', N'Tế bào thực vật tự tổng hợp chất hữu cơ, trong khi tế bào động vật phải tiêu thụ chất hữu cơ.', N'Tế bào thực vật phải tiêu thụ chất hữu cơ, trong khi tế bào động vật tự tổng hợp chất hữu cơ.', N'Tế bào thực vật và tế bào động vật đều tự tổng hợp chất hữu cơ.', N'Tế bào thực vật và tế bào động vật đều phải tiêu thụ chất hữu cơ.', 'A'),
(127, N'Câu 127: Hãy mô tả quá trình trao đổi khí trong cơ thể người.', 'TN', NULL, 'MH007', 'A', N'Là quá trình diễn ra ở phổi, trong đó oxy được hít vào và carbon dioxide được thải ra qua quá trình hô hấp.', N'Là quá trình diễn ra ở phổi, trong đó carbon dioxide được hít vào và oxy được thải ra qua quá trình hô hấp.', N'Là quá trình diễn ra ở phổi, trong đó oxy và carbon dioxide được hít vào thông qua quá trình hô hấp.', N'Là quá trình diễn ra ở phổi, trong đó oxy và carbon dioxide được thải ra qua quá trình hô hấp.', 'A'),
(128, N'Câu 128: Sự khác biệt giữa hệ tiêu hóa của người ăn thực vật và người ăn thức ăn có chứa protein động vật là gì?', 'TN', NULL, 'MH007', 'A', N'Hệ tiêu hóa của người ăn thực vật có thêm một bước tiêu hóa chất xơ, trong khi người ăn thức ăn có chứa protein động vật không có bước này.', N'Hệ tiêu hóa của người ăn thực vật không khác biệt nào so với người ăn thức ăn có chứa protein động vật.', N'Hệ tiêu hóa của người ăn thực vật không có bước tiêu hóa chất xơ, trong khi người ăn thức ăn có chứa protein động vật có bước này.', N'Hệ tiêu hóa của người ăn thực vật có thêm một bước tiêu hóa protein, trong khi người ăn thức ăn có chứa protein động vật không có bước này.', 'A'),
(129, N'Câu 129: Sự khác biệt giữa tế bào thực vật và tế bào động vật trong quá trình phân bào là gì?', 'TN', NULL, 'MH007', 'A', N'Tế bào thực vật thường có tường bao cứng, trong khi tế bào động vật không có tường bao.', N'Tế bào thực vật và tế bào động vật phân bào theo cách tương tự nhau.', N'Tế bào thực vật thường có một lõi nhân, trong khi tế bào động vật có nhiều lõi nhân.', N'Tế bào thực vật không có lõi nhân, trong khi tế bào động vật có một lõi nhân.', 'A'),
(130, N'Câu 130: Hãy mô tả sự khác biệt giữa quá trình hô hấp của động vật lưỡng cư và động vật thuộc lớp Cá.', 'TN', NULL, 'MH007', 'A', N'Động vật lưỡng cư hô hấp thông qua da và phổi, trong khi động vật lớp Cá hô hấp thông qua mang và phổi.', N'Động vật lưỡng cư hô hấp thông qua mang và phổi, trong khi động vật lớp Cá hô hấp thông qua da và phổi.', N'Động vật lưỡng cư không hô hấp bằng phổi, trong khi động vật lớp Cá hô hấp bằng phổi.', N'Động vật lưỡng cư và động vật lớp Cá hô hấp bằng cùng một phương pháp.', 'A');

-- Thêm 10 câu hỏi mẫu về môn Vật Lý (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(131, N'Câu 131: Ánh sáng trắng khi chiếu qua một lăng kính tròn có thể tách thành các màu sắc cấu thành ánh sáng mặt trời. Hiện tượng này gọi là gì?', 'TN', NULL, 'MH008', 'A', N'Thủy tinh màu', N'Phản xạ ánh sáng', N'Hiệu ứng Compton', N'Phân tán ánh sáng', 'A'),
(132, N'Câu 132: Quang điện giải thích sự phát ra ánh sáng của các nguyên tử khi được kích thích. Phát biểu nào dưới đây mô tả chính xác về quang điện?', 'TN', NULL, 'MH008', 'A', N'Ánh sáng được phát ra khi nguyên tử bị tác động bởi nhiệt độ cao.', N'Ánh sáng được phát ra khi nguyên tử chuyển từ trạng thái năng lượng cao xuống trạng thái thấp hơn.', N'Ánh sáng được phát ra khi nguyên tử bị va đập mạnh.', N'Ánh sáng được phát ra khi nguyên tử bị chiếu ánh sáng từ bên ngoài.', 'B'),
(133, N'Câu 133: Sự phân cực ánh sáng xảy ra khi nào?', 'TN', NULL, 'MH008', 'A', N'Khi ánh sáng đi qua một môi trường khác có chỉ số khúc xạ khác nhau.', N'Khi ánh sáng đi qua không khí.', N'Khi ánh sáng đi qua một môi trường có chỉ số khúc xạ bằng nhau.', N'Khi ánh sáng đi qua môi trường đồng nhất.', 'A'),
(134, N'Câu 134: Đơn vị đo lường năng lượng ánh sáng trong hệ SI là gì?', 'TN', NULL, 'MH008', 'A', N'Mol', N'Ampere', N'Candela', N'Joule', 'D'),
(135, N'Câu 135: Hiệu ứng Doppler trong vật lý mô tả hiện tượng gì?', 'TN', NULL, 'MH008', 'A', N'Thứ tự mà sóng âm được tạo ra', N'Thứ tự mà sóng âm được thu lại', N'Thứ tự mà sóng âm bị biến đổi về tần số', N'Thứ tự mà sóng âm bị biến đổi về bước sóng', 'C'),
(136, N'Câu 136: Nguồn sáng làm việc tương tự như một nguồn nào khác trong hệ thống sóng?', 'TN', NULL, 'MH008', 'A', N'Nguồn sóng âm', N'Nguồn sóng cơ', N'Nguồn sóng điện từ', N'Nguồn sóng học', 'C'),
(137, N'Câu 137: Tần số của sóng âm đo bằng đơn vị gì?', 'TN', NULL, 'MH008', 'A', N'Hertz (Hz)', N'Watt (W)', N'Pascal (Pa)', N'Volt (V)', 'A'),
(138, N'Câu 138: Một nguồn phát sóng phát ra âm thanh với tần số 440 Hz. Đây là tần số của âm nào trong âm nhạc cổ điển?', 'TN', NULL, 'MH008', 'A', N'La', N'Si', N'Do', N'Mi', 'A'),
(139, N'Câu 139: Trong vật lý, đơn vị đo áp suất là gì?', 'TN', NULL, 'MH008', 'A', N'Pascal (Pa)', N'Watt (W)', N'Hertz (Hz)', N'Joule (J)', 'A'),
(140, N'Câu 140: Điều gì xác định màu sắc của vật?', 'TN', NULL, 'MH008', 'A', N'Tần số của ánh sáng phản xạ từ vật', N'Nhiệt độ của ánh sáng phản xạ từ vật', N'Độ bóng của vật', N'Cả hai câu trên', 'A');

-- Thêm 10 câu hỏi mẫu về môn Tin Học (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(141, N'Câu 141: Khái niệm "Phần mềm" trong tin học là gì?', 'TN', NULL, 'MH009', 'A', N'Là phần cứng của máy tính.', N'Là một chuỗi các lệnh máy tính.', N'Là tập hợp các chương trình máy tính.', N'Là các thành phần cơ bản của máy tính.', 'C'),
(142, N'Câu 142: Phần mềm hệ điều hành có chức năng gì trong máy tính?', 'TN', NULL, 'MH009', 'A', N'Quản lý và điều khiển tài nguyên của máy tính.', N'Tạo ra các ứng dụng văn phòng.', N'Kết nối máy tính với internet.', N'Quản lý cấu hình phần cứng của máy tính.', 'A'),
(143, N'Câu 143: Khái niệm "Phần cứng" trong tin học là gì?', 'TN', NULL, 'MH009', 'A', N'Là các chương trình và tập tin lưu trữ.', N'Là thành phần vận hành của máy tính.', N'Là môi trường làm việc của người dùng.', N'Là phần mềm cần thiết để hoạt động máy tính.', 'B'),
(144, N'Câu 144: Phần cứng CPU có nhiệm vụ gì trong máy tính?', 'TN', NULL, 'MH009', 'A', N'Thu thập thông tin từ người dùng.', N'Xử lý các tác vụ và dữ liệu trong máy tính.', N'Hiển thị thông tin ra màn hình.', N'Lưu trữ dữ liệu lâu dài.', 'B'),
(145, N'Câu 145: RAM (Bộ nhớ truy cập ngẫu nhiên) trong máy tính có chức năng gì?', 'TN', NULL, 'MH009', 'A', N'Lưu trữ dữ liệu lâu dài.', N'Là nơi lưu trữ các tập tin.', N'Là bộ nhớ tạm thời cho dữ liệu và các chương trình đang chạy.', N'Quản lý các tác vụ của máy tính.', 'C'),
(146, N'Câu 146: Định dạng tệp tin .docx thường được sử dụng cho loại tài liệu nào?', 'TN', NULL, 'MH009', 'A', N'Tệp tin âm nhạc.', N'Tệp tin hình ảnh.', N'Tệp tin văn bản.', N'Tệp tin video.', 'C'),
(147, N'Câu 147: Định dạng tệp tin .jpeg thường được sử dụng cho loại hình ảnh nào?', 'TN', NULL, 'MH009', 'A', N'Hình ảnh động.', N'Hình ảnh không nén.', N'Hình ảnh định dạng cao.', N'Hình ảnh nén.', 'D'),
(148, N'Câu 148: Công cụ nào dùng để trình bày dữ liệu dưới dạng biểu đồ trong Excel?', 'TN', NULL, 'MH009', 'A', N'Hàm tính toán.', N'Bảng tính.', N'Chart hoặc Biểu đồ.', N'Trình soạn thảo văn bản.', 'C'),
(149, N'Câu 149: Định dạng tệp tin .mp3 thường được sử dụng cho loại nội dung nào?', 'TN', NULL, 'MH009', 'A', N'Video.', N'Âm nhạc.', N'Tập tin văn bản.', N'Hình ảnh.', 'B'),
(150, N'Câu 150: Định dạng tệp tin .avi thường được sử dụng cho loại nội dung nào?', 'TN', NULL, 'MH009', 'A', N'Video.', N'Hình ảnh.', N'Âm nhạc.', N'Tập tin văn bản.', 'A');

-- Thêm 10 câu hỏi mẫu về môn GDCD (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(151, N'Câu 151: Đặc điểm nào xác định một chế độ chính trị dân chủ?', 'TN', NULL, 'MH010', 'A', N'Sự tự do ngôn luận và quyền bình đẳng của mọi công dân.', N'Trang bị quân sự mạnh mẽ và kiểm soát nghiêm ngặt.', N'Thống trị của một người đứng đầu nhà nước.', N'Sự tập trung quyền lực vào một tổ chức chính trị.', 'A'),
(152, N'Câu 152: Quyền nào được coi là quyền cơ bản và quyết định trong một xã hội dân chủ?', 'TN', NULL, 'MH010', 'A', N'Quyền bình đẳng và quyền tự do cá nhân.', N'Quyền tìm kiếm và bảo vệ sự công bằng.', N'Quyền tìm kiếm và bảo vệ sự công bằng.', N'Quyền kiểm soát và quản lý nguồn lực tự nhiên.', 'A'),
(153, N'Câu 153: Tính cách mạng của 1789 ở Pháp có ý nghĩa gì trong lịch sử phong trào dân chủ thế giới?', 'TN', NULL, 'MH010', 'A', N'Là sự kiện mở đầu cho sự nổi dậy chống lại chế độ phong kiến.', N'Là sự kiện mở đầu cho sự lên án của chủ nghĩa cộng sản.', N'Là sự kiện mở đầu cho sự trỗi dậy của phong trào dân chủ thế giới.', N'Là sự kiện mở đầu cho sự lên tiếng của chủ nghĩa quốc gia.', 'C'),
(154, N'Câu 154: Ý nghĩa của Quốc hội Cách mạng tháng Mười Nga trong lịch sử phong trào cách mạng dân chủ thế giới là gì?', 'TN', NULL, 'MH010', 'A', N'Là sự kiện mở đầu cho sự nổi dậy chống lại chế độ phong kiến.', N'Là sự kiện mở đầu cho sự lên án của chủ nghĩa cộng sản.', N'Là sự kiện mở đầu cho sự trỗi dậy của phong trào dân chủ thế giới.', N'Là sự kiện mở đầu cho sự lên tiếng của chủ nghĩa quốc gia.', 'C'),
(155, N'Câu 155: Hiểu đúng về quyền và nghĩa vụ công dân là gì?', 'TN', NULL, 'MH010', 'A', N'Quyền là khả năng thực hiện các hành động mà luật pháp bảo đảm, nghĩa vụ là trách nhiệm phải tuân thủ các quy định của pháp luật.', N'Quyền là trách nhiệm phải tuân thủ các quy định của pháp luật, nghĩa vụ là khả năng thực hiện các hành động mà luật pháp bảo đảm.', N'Quyền và nghĩa vụ công dân không liên quan gì đến nhau.', N'Quyền và nghĩa vụ công dân không quan trọng trong xã hội dân chủ.', 'A'),
(156, N'Câu 156: Quyền tự do ngôn luận là gì và tại sao nó quan trọng?', 'TN', NULL, 'MH010', 'A', N'Là quyền tự do biểu đạt ý kiến và suy nghĩ của mình, quan trọng vì nó là nền tảng của xã hội dân chủ.', N'Là quyền tự do diễn đạt bản thân mình, quan trọng vì nó là yếu tố cần thiết trong xã hội tôn trọng.', N'Là quyền tự do hành động và diễn đạt ý kiến, quan trọng vì nó tạo điều kiện cho sự đoàn kết.', N'Là quyền tự do hành động và suy nghĩ của mình, quan trọng vì nó giúp xã hội thống nhất.', 'A'),
(157, N'Câu 157: Khái niệm "Pháp luật" có ý nghĩa gì trong xã hội dân chủ?', 'TN', NULL, 'MH010', 'A', N'Là bộ quy tắc và quy định được xác lập bởi chính phủ, quan trọng để duy trì trật tự xã hội.', N'Là bộ quy tắc và quy định được xác lập bởi nhà nước, quan trọng để duy trì trật tự xã hội.', N'Là bộ quy tắc và quy định được xác lập bởi cộng đồng, quan trọng để duy trì trật tự xã hội.', N'Là bộ quy tắc và quy định được xác lập bởi người dân, quan trọng để duy trì trật tự xã hội.', 'A'),
(158, N'Câu 158: Đặc điểm nào xác định một xã hội công bằng?', 'TN', NULL, 'MH010', 'A', N'Xã hội có sự phân chia rõ ràng về tầng lớp và địa vị.', N'Xã hội không có sự phân chia về tầng lớp và địa vị.', N'Xã hội có sự phân chia nhưng công bằng về cơ hội và quyền lợi.', N'Xã hội không có sự phân chia về cơ hội và quyền lợi.', 'C'),
(159, N'Câu 159: Tại sao việc tham gia vào các hoạt động cộng đồng được xem là trách nhiệm của công dân trong xã hội dân chủ?', 'TN', NULL, 'MH010', 'A', N'Việc tham gia cộng đồng giúp nâng cao địa vị xã hội của mỗi người.', N'Việc tham gia cộng đồng giúp tạo ra cơ hội phát triển cá nhân.', N'Việc tham gia cộng đồng giúp xây dựng và duy trì một xã hội tốt đẹp.', N'Việc tham gia cộng đồng giúp mỗi người có quyền lợi cao hơn.', 'C'),
(160, N'Câu 160: Tại sao việc tham gia bầu cử được xem là một trách nhiệm quan trọng của công dân?', 'TN', NULL, 'MH010', 'A', N'Vì việc tham gia bầu cử là cơ hội để bày tỏ quan điểm cá nhân.', N'Vì việc tham gia bầu cử giúp mỗi người có quyền lợi cao hơn.', N'Vì việc tham gia bầu cử là cách duy nhất để thể hiện ý kiến.', N'Vì việc tham gia bầu cử giúp xây dựng và duy trì một xã hội dân chủ.', 'D');

-- Thêm 10 câu hỏi mẫu về môn Thể Dục (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(161, N'Câu 161: Tại sao việc tập luyện thể dục thường xuyên quan trọng đối với sức khỏe?', 'TN', NULL, 'MH011', 'A', N'Tăng cường cơ bắp và tăng cường hệ miễn dịch.', N'Tăng cường khả năng học tập và tập trung.', N'Tăng cường khả năng giao tiếp và tăng cường thể chất.', N'Tăng cường khả năng tư duy và tăng cường sức mạnh tinh thần.', 'A'),
(162, N'Câu 162: Lợi ích của việc tham gia các hoạt động thể dục định kỳ là gì?', 'TN', NULL, 'MH011', 'A', N'Giảm căng thẳng và cải thiện tâm trạng.', N'Tăng cường cơ bắp và tăng cường sức mạnh.', N'Tăng cường sức khỏe tinh thần và giảm cân.', N'Tăng cường thể chất và tăng cường sức mạnh tinh thần.', 'A'),
(163, N'Câu 163: Hiểu biết về lợi ích của việc duy trì một lối sống vận động là gì?', 'TN', NULL, 'MH011', 'A', N'Giúp giảm nguy cơ mắc các bệnh tim mạch và tăng cường sức khỏe.', N'Giúp giảm nguy cơ mắc bệnh tiểu đường và tăng cường sức khỏe.', N'Giúp giảm căng thẳng và tăng cường sức khỏe tinh thần.', N'Giúp giảm cân và tăng cường cơ bắp.', 'A'),
(164, N'Câu 164: Ích lợi của việc thực hiện bài tập thể dục đều đặn hàng ngày là gì?', 'TN', NULL, 'MH011', 'A', N'Tăng cường khả năng học tập và tập trung.', N'Giảm căng thẳng và cải thiện tâm trạng.', N'Tăng cường cơ bắp và tăng cường sức mạnh.', N'Tăng cường sức khỏe tinh thần và giảm cân.', 'C'),
(165, N'Câu 165: Tại sao việc rèn luyện thể chất là quan trọng đối với mọi người?', 'TN', NULL, 'MH011', 'A', N'Để tăng cường sức mạnh và cải thiện vóc dáng.', N'Để giảm căng thẳng và cải thiện tâm trạng.', N'Để tăng cường khả năng học tập và tập trung.', N'Để duy trì sức khỏe tốt và ngăn ngừa các bệnh tật.', 'D'),
(166, N'Câu 166: Hiểu biết về vai trò của thể dục thể thao trong cuộc sống hàng ngày là gì?', 'TN', NULL, 'MH011', 'A', N'Thể dục thể thao giúp mọi người có vóc dáng đẹp và thu hút.', N'Thể dục thể thao giúp mọi người cảm thấy thoải mái và thoải mái.', N'Thể dục thể thao giúp mọi người duy trì sức khỏe tốt và tăng cường sức mạnh.', N'Thể dục thể thao giúp mọi người trở nên mạnh mẽ và tự tin hơn.', 'C'),
(167, N'Câu 167: Tại sao việc rèn luyện thể chất được coi là một phần quan trọng của cuộc sống?', 'TN', NULL, 'MH011', 'A', N'Để tạo ra sự quyến rũ và thu hút.', N'Để duy trì sức khỏe tốt và ngăn ngừa các bệnh tật.', N'Để tăng cường sức mạnh và cải thiện vóc dáng.', N'Để giảm căng thẳng và cải thiện tâm trạng.', 'B'),
(168, N'Câu 168: Tại sao việc thực hiện thể dục thể thao được khuyến khích trong môi trường công ty?', 'TN', NULL, 'MH011', 'A', N'Để tăng cường sức khỏe tinh thần và cải thiện tâm trạng.', N'Để giảm căng thẳng và cải thiện tâm trạng.', N'Để tăng cường khả năng học tập và tập trung.', N'Để duy trì sức khỏe tốt và ngăn ngừa các bệnh tật.', 'A'),
(169, N'Câu 169: Ích lợi của việc thực hiện các bài tập thể dục định kỳ trong cuộc sống hàng ngày là gì?', 'TN', NULL, 'MH011', 'A', N'Tăng cường sức khỏe tinh thần và giảm căng thẳng.', N'Tăng cường sức khỏe tinh thần và giảm cân.', N'Tăng cường sức khỏe tinh thần và cải thiện tâm trạng.', N'Tăng cường sức khỏe tinh thần và cải thiện vóc dáng.', 'A'),
(170, N'Câu 170: Hiểu biết về tầm quan trọng của việc duy trì một lối sống vận động là gì?', 'TN', NULL, 'MH011', 'A', N'Giúp giảm căng thẳng và cải thiện tâm trạng.', N'Giúp giảm nguy cơ mắc các bệnh tim mạch và tăng cường sức khỏe.', N'Giúp giảm căng thẳng và tăng cường sức khỏe tinh thần.', N'Giúp giảm nguy cơ mắc bệnh tiểu đường và tăng cường sức khỏe.', 'B');

-- Thêm 10 câu hỏi mẫu về môn Âm Nhạc (10 lop 10,10 lop 11, 10 cau lop 12) vào bảng CauHoi_Gop
INSERT INTO CauHoi_Gop (MaCH, NoiDung, HinhThucCH, Hinh, MaMon, DoKho, DapAn_A, DapAn_B, DapAn_C, DapAn_D, DapAn)
VALUES 
(171, N'Câu 171: Khái niệm "Tempo" trong âm nhạc đề cập đến điều gì?', 'TN', NULL, 'MH012', 'A', N'Tốc độ của bài hát.', N'Lời bài hát.', N'Âm sắc của bài hát.', N'Phong cách biểu diễn của bài hát.', 'A'),
(172, N'Câu 172: Các nốt nhạc được sắp xếp theo thứ tự tăng dần hoặc giảm dần của âm thanh được gọi là gì?', 'TN', NULL, 'MH012', 'A', N'Nốt cao và nốt thấp.', N'Nốt nhạc và tempo.', N'Nốt nhạc và nhịp.', N'Thăng và giảm.', 'A'),
(173, N'Câu 173: Khái niệm "Dynamics" trong âm nhạc đề cập đến điều gì?', 'TN', NULL, 'MH012', 'A', N'Thời gian diễn ra của bài hát.', N'Độ lớn và nhỏ của âm thanh.', N'Lời bài hát.', N'Cách biểu diễn của ca sĩ.', 'B'),
(174, N'Câu 174: Khái niệm "Pitch" trong âm nhạc đề cập đến điều gì?', 'TN', NULL, 'MH012', 'A', N'Độ âm sắc của bài hát.', N'Tốc độ của bài hát.', N'Độ cao và thấp của âm thanh.', N'Độ lớn và nhỏ của âm thanh.', 'C'),
(175, N'Câu 175: Khái niệm "Rhythm" trong âm nhạc đề cập đến điều gì?', 'TN', NULL, 'MH012', 'A', N'Âm sắc của bài hát.', N'Thời gian diễn ra của bài hát.', N'Lời bài hát.', N'Nhịp của bài hát.', 'D'),
(176, N'Câu 176: Khái niệm "Melody" trong âm nhạc đề cập đến điều gì?', 'TN', NULL, 'MH012', 'A', N'Thời gian diễn ra của bài hát.', N'Lời bài hát.', N'Nhịp của bài hát.', N'Sự kết hợp của nhiều âm thanh.', 'D'),
(177, N'Câu 177: Khái niệm "Chord" trong âm nhạc đề cập đến điều gì?', 'TN', NULL, 'MH012', 'A', N'Nốt cao và nốt thấp.', N'Nốt nhạc và tempo.', N'Nốt nhạc và nhịp.', N'Sự kết hợp của nhiều âm thanh.', 'D'),
(178, N'Câu 178: Công dụng chính của "Clef" trong âm nhạc là gì?', 'TN', NULL, 'MH012', 'A', N'Xác định thời gian và tốc độ của bài hát.', N'Xác định âm sắc và cường độ của bài hát.', N'Xác định nhịp và nhịp điệu của bài hát.', N'Xác định nốt và vị trí của nốt trên bản nhạc.', 'D'),
(179, N'Câu 179: Khái niệm "Harmony" trong âm nhạc đề cập đến điều gì?', 'TN', NULL, 'MH012', 'A', N'Nhịp và nhịp điệu của bài hát.', N'Thời gian diễn ra của bài hát.', N'Sự kết hợp của nhiều âm thanh.', N'Sự kết hợp của nhiều nốt nhạc.', 'D'),
(180, N'Câu 180: Đặc điểm nào quan trọng nhất của một bản nhạc để tạo nên một bài hát hoàn chỉnh?', 'TN', NULL, 'MH012', 'A', N'Melody (giai điệu).', N'Rhythm (nhịp điệu).', N'Harmony (hòa âm).', N'Dynamics (độ lớn của âm thanh).', 'A');

-- Tạo 5 kỳ thi vào bảng KyThi
INSERT INTO KyThi (MaMon, TenKT, DoiTuong, MaNV, TGLamBai, TGMoDe, TGDongDe, TongSoCau, TLDe, TLKho, TDDe, TDKho, CauMDA, CauNDA, CauDT, Chat, TienLui, Mat, MatKhau)
VALUES 
('MH001', N'Kiểm tra giữa kỳ', N'Lớp 10', 'NV001', 90, '2024-02-10 08:00', '2024-02-10 09:30', 40, 40, 30, 5, 7, 1, 0, 0, 1, 1, 0, NULL),
('MH002', N'Kiểm tra học kỳ 1', N'Lớp 10', 'NV002', 120, '2024-03-15 09:00', '2024-03-15 11:00', 50, 30, 40, 8, 9, 1, 0, 1, 1, 1, 0, NULL),
('MH003', N'Đánh giá cuối kỳ', N'Lớp 11', 'NV003', 150, '2024-04-20 07:30', '2024-04-20 10:00', 60, 25, 45, 9, 10, 0, 1, 0, 1, 1, 0, NULL),
('MH004', N'Kiểm tra học kỳ 2', N'Lớp 11', 'NV004', 120, '2024-05-25 08:30', '2024-05-25 10:30', 50, 35, 35, 6, 8, 0, 1, 1, 0, 1, 0, NULL),
('MH005', N'Đánh giá cuối kỳ', N'Lớp 12', 'NV005', 180, '2024-06-30 07:00', '2024-06-30 10:00', 70, 20, 50, 7, 9, 1, 0, 0, 1, 1, 1, 'password123');

-- Tạo 5 kết quả kiểm tra của thí sinh
INSERT INTO KetQua (MaTS, MaKyThi, NgayThi, Diem, TongTGThi, TGTraLoiDe, TGTraLoiTrungBinh, Loai)
VALUES 
('TS001', 2, '12/12/2023 12:12:12.0 PM', 8.5, 3600, 1800, 120, 1),
('TS002', 3, '12/15/2023 01:20:00.0 PM', 9.0, 4500, 2400, 180, 1),
('TS003', 4, '12/18/2023 10:30:00.0 AM', 7.5, 3200, 1500, 100, 0),
('TS004', 5, '12/20/2023 11:00:00.0 AM', 6.8, 3800, 2000, 150, 0),
('TS005', 6, '12/25/2023 02:45:00.0 PM', 8.0, 4200, 2200, 140, 1);

-- Tạo 5 báo cáo lỗi
INSERT INTO BaoCaoLoi (Loai, MoTa, MaTS, TinhTrang)
VALUES 
(N'Quên mật khẩu', N'Không thể đăng nhập do quên mật khẩu', 'TS001', N'Chưa xử lý'),
(N'Câu hỏi bị lỗi', N'Câu hỏi số 5 trong kỳ thi 3 không hiển thị đúng', 'TS002', N'Đã xử lý'),
(N'Phát hiện gian lận', N'Thí sinh TS003 đã sử dụng tài liệu cấm trong kỳ thi', 'TS003', N'Chưa xử lý'),
(N'Lỗi hệ thống', N'Hệ thống gặp sự cố khi đăng nhập', 'TS004', N'Đang xử lý'),
(N'Lỗi chấm điểm', N'Câu hỏi số 7 trong kỳ thi 4 không tính điểm đúng', 'TS005', N'Chưa xử lý');

-- Tạo 5 chatbox
INSERT INTO ChatBox (Loai, MaN1, MaN2)
VALUES 
('1', 'TS001', 'TS002'),
('2', 'NV001', 'TS003'),
('3', 'NV002', 'NV003'),
('1', 'TS004', 'TS005'),
('2', 'NV003', 'TS002');

-- Tạo 5 bản ghi trong bảng ChatMess
INSERT INTO ChatMess (IDBox, MaN, NoiDung)
VALUES 
(1, N'TS001', N'Có gì đó sai sai'),
(1, N'TS002', N'Chắc phải kiểm tra lại đây'),
(2, N'NV001', N'Chào bạn, có thể giúp gì không?'),
(2, N'TS003', N'Xin chào, tôi đang gặp vấn đề này'),
(3, N'NV002', N'Bạn cần hỗ trợ vấn đề gì ạ?');

-- Tạo 5 phiếu trả lời
INSERT INTO PhieuTraLoi (MaKQ, STT, HinhThucCH, MaCH, DapAn, ChuoiDapAn)
VALUES 
(1, 1, 'M', 101, N'A', N'Đáp án A'),
(1, 2, 'M', 102, N'B', N'Đáp án B'),
(2, 1, 'M', 103, N'C', N'Đáp án C'),
(2, 2, 'M', 104, N'D', N'Đáp án D'),
(3, 1, 'M', 105, N'A', N'Đáp án A');

-- Tạo 5 bản ghi trong bảng LogThi
INSERT INTO LogThi (MaTS, MaKyThi, Thi)
VALUES 
('TS001', '1', 1),
('TS002', '2', 0),
('TS003', '1', 1),
('TS004', '3', 1),
('TS005', '2', 0);
