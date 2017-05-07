Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Departure As Object = ComboBox1.Text
        If (ComboBox1.Text = "سوهاج" Or ComboBox1.Text = "القاهرة" Or ComboBox1.Text = "الاسكندرية" Or ComboBox1.Text = "أبو سمبل" Or ComboBox1.Text = "أسوان" Or ComboBox1.Text = "الأقصر" Or ComboBox1.Text = "الغردقة" Or ComboBox1.Text = "سانت كاثرين" Or ComboBox1.Text = "شرم الشيخ" Or ComboBox1.Text = "مرسى علم" Or ComboBox1.Text = "مرسى مطروح") Then

            ComboBox2.Items.Remove("سوهاج")
            ComboBox2.Items.Remove("القاهرة")
            ComboBox2.Items.Remove("الاسكندرية")
            ComboBox2.Items.Remove("أبو سمبل")
            ComboBox2.Items.Remove("أسوان")
            ComboBox2.Items.Remove("الأقصر")
            ComboBox2.Items.Remove("الغردقة")
            ComboBox2.Items.Remove("سانت كاثرين")
            ComboBox2.Items.Remove("شرم الشيخ")
            ComboBox2.Items.Remove("مرسى علم")
            ComboBox2.Items.Remove("مرسى مطروح")
            ComboBox2.Items.Add("سوهاج")
            ComboBox2.Items.Add("القاهرة")
            ComboBox2.Items.Add("الاسكندرية")
            ComboBox2.Items.Add("أبو سمبل")
            ComboBox2.Items.Add("أسوان")
            ComboBox2.Items.Add("الأقصر")
            ComboBox2.Items.Add("الغردقة")
            ComboBox2.Items.Add("سانت كاثرين")
            ComboBox2.Items.Add("شرم الشيخ")
            ComboBox2.Items.Add("مرسى علم")
            ComboBox2.Items.Add("مرسى مطروح")
            ComboBox2.Items.Remove(Departure)
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
