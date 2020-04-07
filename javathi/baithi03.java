import com.sun.tracing.dtrace.ArgsAttributes;
import java.util.ArrayList;
import java.util.Scanner;


    public class ProgramStudent {
        private ArrayList<Student> StudentList = new ArrayList<>();

        Scanner sc = new Scanner(System.in);

        public void addStudent() {
            System.out.println("nhập số học sinh muốn thêm");
            int n = sc.nextInt();
            for (int i = 0; i < n; i++) {
                System.out.println("nhập tên sinh viên theo thứ" + (i + 1));
                String name = sc.next();
                System.out.println("nhập địa chỉ sinh viên theo thứ" + (i + 1));
                String address = sc.next();
                System.out.println("nhập số điện thoại của sinh viên theo thứ" + (i + 1));
                String phone = sc.next();
                Student student = new Student(name,address,phone);
                StudentList.add (new Student(student.getName(),student.getAddress(),studen.getPhone()));

            }
        }
        public  void displayStudent(){
            System.out.println("danh sách học sinh ");
            Interator<Student> StudentInterator = StudentList.interator();
            while (StudentInterator.hasNext()){
                Student st1 = StudentInterator.next();
                System.out.println(st1);
            }
        }
    }
    }