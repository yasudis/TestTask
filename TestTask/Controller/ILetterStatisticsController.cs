namespace TestTask
{
    /// ��������� ��� ������ � ������ � ������� ����������.
    /// ����� ����� 2 ����: ��������� ������, � ������� ���������� �� �����.

    public interface ILetterStatisticsController
    {
        /// <summary>
        /// �-��� ����������� �� ��������� ������ ��� �����, � ������������ ��������� ��������� ��������� ������ �����.
        /// ���������� �����������������!
        /// </summary>

        /// <returns>��������� ��������� �� ������ �����, ��� ���� ��������� �� ������.</returns>
        /// /// <param name="args">������ ���� �� ����� ��� ������.</param>
        void CalculateLetterStatistics(string args);

        /// <summary>
        /// �-��� ���������� ��� ��������� �����/������ �����, ���������� � ���� ������ ������� ��� ��������� �����.
        /// (��� ���� ��� �������� ������������ ���������� charType)
        /// ��� ��������� �����/���� ��������������� ��������� ������ - ��������� �� ���������� ��������� ���������.
        /// </summary>
        /// <param name="charType">��� ���� ��� �������</param>
        void RemoveCharStatsByType(CharType charType);

        /// <summary>
        /// �-��� ������� �� ����� ���������� ���������� � ������� "{�����} : {���-��}"
        /// ������ ����� - � ����� ������. 
        /// � ����� ��������� ������� � �����, ���������� � ���� ����� ���-�� ��������� ����/���
        /// </summary>
        void PrintStatistic();
    }
}
